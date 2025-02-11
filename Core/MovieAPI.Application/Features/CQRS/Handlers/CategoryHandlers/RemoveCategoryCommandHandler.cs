using MovieAPI.Application.Features.CQRS.Commands.CategoryCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handle(RemoveCategoryCommand command)
        {
            var entity = await _context.Categories.FindAsync(command.Id);
            _context.Categories.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
