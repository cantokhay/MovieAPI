using Microsoft.EntityFrameworkCore;
using MovieAPI.Application.Features.CQRS.Results.MovieResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var valueList = await _context.Movies.Where(x => x.DataStatus != Domain.Entities.Enum.DataStatus.Deleted).ToListAsync();
            return valueList.Select(c => new GetMovieQueryResult
            {
                Id = c.Id,
                MovieTitle = c.MovieTitle,
                MovieCoverImageURL = c.MovieCoverImageURL,
                MovieDescription = c.MovieDescription,
                MovieRating = c.MovieRating,
                MovieDuration = c.MovieDuration,
                MovieReleaseDate = c.MovieReleaseDate,
                MovieReleaseYear = c.MovieReleaseYear,
                MovieStatus = c.MovieStatus
            }).ToList();
        }
    }
}
