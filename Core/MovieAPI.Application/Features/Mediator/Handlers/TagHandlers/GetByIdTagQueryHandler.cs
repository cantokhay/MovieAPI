using MediatR;
using MovieAPI.Application.Features.Mediator.Queries.TagQueries;
using MovieAPI.Application.Features.Mediator.Results.TagResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetByIdTagQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetByIdTagQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tags.FindAsync(request.Id);
            return new GetTagByIdQueryResult
            {
                Id = entity.Id,
                DataStatus = entity.DataStatus,
                CreatedDate = entity.CreatedDate,
                ModifiedDate = entity.ModifiedDate,
                DeletedDate = entity.DeletedDate,
                TagTitle = entity.TagTitle
            };
        }
    }
}
