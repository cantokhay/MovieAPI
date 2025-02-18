using MovieAPI.Application.Features.CQRS.Commands.MovieCommands;
using MovieAPI.Domain.Entities.Enum;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var entity = await _context.Movies.FindAsync(command.Id);
            entity.DataStatus = DataStatus.Modified;
            entity.CreatedDate = command.CreatedDate;
            entity.ModifiedDate = DateTime.Now;
            entity.DeletedDate = null;
            entity.MovieTitle = command.MovieTitle;
            entity.MovieCoverImageURL = command.MovieCoverImageURL;
            entity.MovieRating = command.MovieRating;
            entity.MovieDescription = command.MovieDescription;
            entity.MovieDuration = command.MovieDuration;
            entity.MovieReleaseDate = command.MovieReleaseDate;
            entity.MovieReleaseYear = command.MovieReleaseYear;
            entity.MovieStatus = command.MovieStatus;
            await _context.SaveChangesAsync();
        }
    }
}
