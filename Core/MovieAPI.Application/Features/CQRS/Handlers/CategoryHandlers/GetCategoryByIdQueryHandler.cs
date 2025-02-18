using MovieAPI.Application.Features.CQRS.Queries.CategoryQueries;
using MovieAPI.Application.Features.CQRS.Results.CategoryResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _context;
        public GetCategoryByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var entity = await _context.Categories.FindAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                Id = entity.Id,
                CategoryName = entity.CategoryName,
            };
        }
    }
}
