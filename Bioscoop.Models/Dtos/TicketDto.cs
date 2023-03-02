using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Models.Dtos
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int ShowId { get; set; }
        public DateTime ShowStartDateTime { get; set; }
        public int MovieId { get; set; }
        public required string MovieTitle { get; set; }
        public int MoviePlayTime { get; set; }
        public int RoomId { get; set; }
        public required string RoomName { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public double Price { get; set; }
    }
}
