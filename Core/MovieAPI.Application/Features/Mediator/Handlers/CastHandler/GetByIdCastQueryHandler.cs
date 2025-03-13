using MediatR;
using MovieAPI.Application.Features.Mediator.Queries.CastQueries;
using MovieAPI.Application.Features.Mediator.Results.CastResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.CastHandler
{
    public class GetByIdCastQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetByIdCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Casts.FindAsync(request.Id);
            return new GetCastByIdQueryResult
            {
                Id = entity.Id,
                DataStatus = entity.DataStatus,
                CreatedDate = entity.CreatedDate,
                ModifiedDate = entity.ModifiedDate,
                DeletedDate = entity.DeletedDate,
                CastTitle = entity.CastTitle,
                CastFirstName = entity.CastFirstName,
                CastLastName = entity.CastLastName,
                CastImageURL = entity.CastImageURL,
                CastOverview = entity.CastOverview,
                CastBiography = entity.CastBiography
            };
        }
    }
}
