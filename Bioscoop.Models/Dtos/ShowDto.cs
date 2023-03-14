using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Models.Dtos
{
    public class ShowDto
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public required string MovieTitle { get; set; }
        public required string MovieDescription { get; set; }
        public required string MovieDescription_en { get; set; }
        public required string MovieDescription_nl { get; set; }
        public required string MovieGenre { get; set; }
        public required string MovieImageURL { get; set; }
        public int MoviePlayTime { get; set; }
        public int MovieMinimumAge { get; set; }
        public bool MovieSpecial { get; set; }
        public int RoomId { get; set; }
        public required string RoomName { get; set; }
        public int RoomSeats { get; set; }
        public int RoomRows { get; set; }
        public bool RoomWheelchairFriendly { get; set; }
        public DateTime StartDateTime { get; set; }
        public required string Type { get; set; }
    }
}
