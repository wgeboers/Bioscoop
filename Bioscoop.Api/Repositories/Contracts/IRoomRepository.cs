using Bioscoop.Api.Entities;
using Bioscoop.Models.Dtos;

namespace Bioscoop.Api.Repositories.Contracts
{
    public interface IRoomRepository
    {
        Task<Room> AddRoom(RoomToAddDto roomToAddDto);
        Task<Room> DeleteRoom(int id);
        Task<IEnumerable<Room>> GetRooms();
        Task<Room> GetRoom(int id);
    }
}
