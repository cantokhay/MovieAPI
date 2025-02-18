using MovieAPI.Application.Features.CQRS.Queries.MovieQueries;
using MovieAPI.Application.Features.CQRS.Results.MovieResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var entity = await _context.Movies.FindAsync(query.Id);
            return new GetMovieByIdQueryResult
            {
                Id = entity.Id,
                MovieTitle = entity.MovieTitle,
                MovieCoverImageURL = entity.MovieCoverImageURL,
                MovieDescription = entity.MovieDescription,
                MovieRating = entity.MovieRating,
                MovieDuration = entity.MovieDuration,
                MovieReleaseDate = entity.MovieReleaseDate,
                MovieReleaseYear = entity.MovieReleaseYear,
                MovieStatus = entity.MovieStatus
            };
        }
    }
}
