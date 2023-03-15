namespace Bioscoop.Api.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Description_en { get; set; }
        public required string Description_nl { get; set; }
        public required string Genre { get; set; }
        public required string ImageURL { get; set; }
        public int PlayTime { get; set; }
        public int MinimumAge { get; set; }
        public bool special { get; set; }
    }
}
