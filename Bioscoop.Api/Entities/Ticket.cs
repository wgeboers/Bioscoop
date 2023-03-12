﻿namespace Bioscoop.Api.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int ShowId { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public bool? Secret { get; set; }
    }
}
