using MovieAPI.Application.Features.CQRS.Commands.MovieCommands;
using MovieAPI.Domain.Entities.Concrete;
using MovieAPI.Domain.Entities.Enum;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                MovieTitle = command.MovieTitle,
                MovieCoverImageURL = command.MovieCoverImageURL,
                MovieRating = command.MovieRating,
                MovieDescription = command.MovieDescription,
                MovieDuration = command.MovieDuration,
                MovieReleaseDate = command.MovieReleaseDate,
                MovieReleaseYear = command.MovieReleaseYear,
                MovieStatus = command.MovieStatus,
                CreatedDate = DateTime.Now,
                DataStatus = DataStatus.Created,
                DeletedDate = null,
                ModifiedDate = null
            });
            await _context.SaveChangesAsync();
        }
    }
}
