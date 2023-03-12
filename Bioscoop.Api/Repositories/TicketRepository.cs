using Bioscoop.Api.Data;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Bioscoop.Api.Repositories
{

    //Ticket moet meer info terug geven van de show, film en zaal

    public class TicketRepository : ITicketRepository
    {
        private readonly BioscoopDbContext bioscoopDbContext;

        public TicketRepository(BioscoopDbContext bioscoopDbContext)
        {
            this.bioscoopDbContext = bioscoopDbContext;
        }

        public async Task<Ticket> GetTicket(int id)
        {
            var ticket = await bioscoopDbContext.Tickets.FindAsync(id);
            return ticket;
        }

        public async Task<Ticket> GetTicketByCode(int code)
        {
            var ticket = await bioscoopDbContext.Tickets.FirstOrDefaultAsync(x => x.Code == code);
            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            return await (from show in this.bioscoopDbContext.Shows
                          join ticket in this.bioscoopDbContext.Tickets
                          on show.Id equals ticket.ShowId
                          select new Ticket
                          {
                              Id = ticket.Id,
                              Code = ticket.Code,
                              ShowId = ticket.ShowId,
                              RowNumber = ticket.RowNumber,
                              SeatNumber = ticket.SeatNumber,
                              Price = ticket.Price,
                              PaymentID= ticket.PaymentID,
                          }).ToListAsync();
        }

        private async Task<bool> TicketExists(int showId, int rowNumber, int seatNumber)
        {
            return await this.bioscoopDbContext.Tickets.AnyAsync(c => c.ShowId == showId &&
                                                                 c.RowNumber == rowNumber &&
                                                                 c.SeatNumber == seatNumber);
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByShowId(int showId)
        {
            return await (from show in this.bioscoopDbContext.Shows
                          join ticket in this.bioscoopDbContext.Tickets
                          on show.Id equals ticket.ShowId
                          where show.Id == showId
                          select new Ticket
                          {
                              Id = ticket.Id,
                              Code = ticket.Code,
                              ShowId = ticket.ShowId,
                              RowNumber = ticket.RowNumber,
                              SeatNumber = ticket.SeatNumber,
                              Price = ticket.Price,
                          }).ToListAsync();    
        }

        private async Task<int> TicketCodeGenerator()
        {
            int code;

            while (true)
            {
                code = new Random().Next(0, 999999);
                var alreadyExists = await this.bioscoopDbContext.Tickets.AnyAsync(c => c.Code == code);
                if (!alreadyExists) break;
            }

            return code;
        }

        public async Task<bool> TicketAvailable(int showId)
        {
            var tickets = await GetTicketsByShowId(showId);
            var room = await this.bioscoopDbContext.Rooms.FindAsync(showId);
            var availability = tickets.Count();

            if(availability < room.Seats) {
                return true;
            } else
            {
                return false;
            }
        }



        private async Task<TicketToAddDto> CalculateSeatAndRowNumber(TicketToAddDto ticketToAddDto)
        {
            var ticketsOfShow = await GetTicketsByShowId(ticketToAddDto.ShowId);
            bool isEmpty = !ticketsOfShow.Any();
            if (isEmpty)
            {
                ticketToAddDto.SeatNumber = 1;
            }
            else
            {
                int highestSeatNumber = ticketsOfShow.Max(x => x.SeatNumber);
                ticketToAddDto.SeatNumber = highestSeatNumber + 1;
            }

            int calculateRowNumber = (int)(ticketToAddDto.SeatNumber / 15);
            ticketToAddDto.RowNumber = calculateRowNumber + 1;
           
            return ticketToAddDto;
        }

        public async Task<Ticket> AddTicket(TicketToAddDto ticketToAddDto)
        {
            if (await TicketExists(ticketToAddDto.ShowId, ticketToAddDto.RowNumber, ticketToAddDto.SeatNumber) == false)
            {
                var code = await TicketCodeGenerator();
                var seatAndRowNumber = await CalculateSeatAndRowNumber(ticketToAddDto);
                var ticket = await (from show in this.bioscoopDbContext.Shows
                                    where show.Id == ticketToAddDto.ShowId
                                    select new Ticket
                                    {
                                        ShowId = show.Id,
                                        Code = code,
                                        RowNumber = ticketToAddDto.RowNumber,
                                        SeatNumber = ticketToAddDto.SeatNumber,
                                        Price = ticketToAddDto.Price,
                                    }).SingleOrDefaultAsync();
                if (ticket != null)
                {
                    var result = await this.bioscoopDbContext.Tickets.AddAsync(ticket);
                    await this.bioscoopDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
            return null;
        }

        public async Task<Ticket> DeleteTicket(int id)
        {
            var ticket = await this.bioscoopDbContext.Tickets.FindAsync(id);

            if (ticket != null)
            {
                this.bioscoopDbContext.Tickets.Remove(ticket);
                await this.bioscoopDbContext.SaveChangesAsync();
            }

            return ticket;
        }

        public async Task UpdateTicketPayment(int id, string paymentID)
        {
            if (id != null && paymentID != null)
            {
                var existingTicket = this.bioscoopDbContext.Tickets.Find(id);


                existingTicket.PaymentID = paymentID;    
                await this.bioscoopDbContext.SaveChangesAsync();
                
                
            }
        }
    }
}
