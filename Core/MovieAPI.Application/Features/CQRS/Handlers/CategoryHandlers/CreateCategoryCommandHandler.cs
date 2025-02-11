using MovieAPI.Application.Features.CQRS.Commands.CategoryCommands;
using MovieAPI.Domain.Entities.Concrete;
using MovieAPI.Domain.Entities.Enum;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
                CreatedDate = DateTime.Now,
                DataStatus = DataStatus.Created,
                DeletedDate = null,
                ModifiedDate = null
            });
            await _context.SaveChangesAsync();
        }
    }
}
