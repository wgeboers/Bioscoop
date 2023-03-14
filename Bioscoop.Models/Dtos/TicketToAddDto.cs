using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Models.Dtos
{
    public class TicketToAddDto
    {
        public int ShowId { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public bool Popcorn { get; set; }
        public required string Special { get; set; }
    }
}
