using Microsoft.EntityFrameworkCore;
using MovieAPI.Application.Features.CQRS.Results.CategoryResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var valueList = await _context.Categories.Where(x => x.DataStatus != Domain.Entities.Enum.DataStatus.Deleted).ToListAsync();
            return valueList.Select(c => new GetCategoryQueryResult
            {
                Id = c.Id,
                CategoryName = c.CategoryName
            }).ToList();
        }
    }
}
