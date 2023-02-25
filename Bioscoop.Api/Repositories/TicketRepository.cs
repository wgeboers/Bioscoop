﻿using Bioscoop.Api.Data;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Api.Repositories
{
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

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            var tickets = await bioscoopDbContext.Tickets.ToListAsync();
            return tickets;
        }

        public async Task<Ticket> AddTicket(TicketToAddDto ticketToAddDto)
        {
            var ticket = await (from show in this.bioscoopDbContext.Shows
                                where show.Id == ticketToAddDto.ShowId
                                select new Ticket
                                {
                                    ShowId = show.Id,
                                    RowNumber = ticketToAddDto.RowNumber,
                                    SeatNumber = ticketToAddDto.SeatNumber,
                                    Price = ticketToAddDto.Price,
                                }).SingleOrDefaultAsync();
            if(ticket != null)
            {
                var result = await this.bioscoopDbContext.Tickets.AddAsync(ticket);
                await this.bioscoopDbContext.SaveChangesAsync();
                return result.Entity;
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
    }
}