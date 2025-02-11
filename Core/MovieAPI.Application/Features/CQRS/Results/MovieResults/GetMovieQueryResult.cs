using MovieAPI.Domain.Entities.Enum;

namespace MovieAPI.Application.Features.CQRS.Results.MovieResults
{
    public class GetMovieQueryResult
    {
        public int Id { get; set; }
        public DataStatus DataStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public string MovieTitle { get; set; }
        public string MovieCoverImageURL { get; set; }
        public decimal MovieRating { get; set; }
        public string MovieDescription { get; set; }
        public int MovieDuration { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string MovieReleaseYear { get; set; }
        public MovieStatus MovieStatus { get; set; }
    }
}
