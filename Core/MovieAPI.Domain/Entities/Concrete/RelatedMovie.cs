namespace MovieAPI.Domain.Entities.Concrete
{
    public class RelatedMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public bool IsWatched { get; set; }
    }
}
