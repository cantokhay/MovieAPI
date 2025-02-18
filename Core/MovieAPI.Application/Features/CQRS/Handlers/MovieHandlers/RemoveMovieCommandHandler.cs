using MovieAPI.Application.Features.CQRS.Commands.MovieCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveMovieCommand command)
        {
            var entity = await _context.Movies.FindAsync(command.Id);
            _context.Movies.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
