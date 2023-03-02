using Bioscoop.Api.Data;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Api.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly BioscoopDbContext bioscoopDbContext;

        public RoomRepository(BioscoopDbContext bioscoopDbContext)
        {
            this.bioscoopDbContext = bioscoopDbContext;
        }

        public async Task<Room> GetRoom(int id)
        {
            var room = await bioscoopDbContext.Rooms.FindAsync(id);
            return room;
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            var rooms = await bioscoopDbContext.Rooms.ToListAsync();

            return rooms;
        }

        public async Task<Room> AddRoom(RoomToAddDto roomToAddDto)
        {
            var result = await this.bioscoopDbContext.Rooms.AddAsync(new Room
                                                                    {
                                                                        Name = roomToAddDto.Name,
                                                                        Seats = roomToAddDto.Seats,
                                                                        Rows = roomToAddDto.Rows,
                                                                        WheelchairFriendly = roomToAddDto.WheelchairFriendly,
                                                                    });
            await this.bioscoopDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Room> DeleteRoom(int id)
        {
            var room = await this.bioscoopDbContext.Rooms.FindAsync(id);

            if (room != null)
            {
                this.bioscoopDbContext.Rooms.Remove(room);
                await this.bioscoopDbContext.SaveChangesAsync();
            }

            return room;
        }
    }
}
