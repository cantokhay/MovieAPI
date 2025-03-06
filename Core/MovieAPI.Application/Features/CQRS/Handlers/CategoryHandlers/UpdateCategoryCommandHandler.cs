using MovieAPI.Application.Features.CQRS.Commands.CategoryCommands;
using MovieAPI.Domain.Entities.Enum;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var entity = await _context.Categories.FindAsync(command.Id);
            entity.CategoryName = command.CategoryName;
            entity.CreatedDate = entity.CreatedDate;
            entity.ModifiedDate = DateTime.Now;
            entity.DataStatus = DataStatus.Modified;
            entity.DeletedDate = null;
            await _context.SaveChangesAsync();
        }
    }
}
