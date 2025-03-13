using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Application.Features.Mediator.Queries.CastQueries;
using MovieAPI.Application.Features.Mediator.Results.CastResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.CastHandler
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;

        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                CastBiography = x.CastBiography,
                CastFirstName = x.CastFirstName,
                CastImageURL = x.CastImageURL,
                CastLastName = x.CastLastName,
                CastOverview = x.CastOverview,
                CastTitle = x.CastTitle,
                CreatedDate = x.CreatedDate,
                DataStatus = x.DataStatus,
                DeletedDate = x.DeletedDate,
                Id = x.Id,
                ModifiedDate = x.ModifiedDate
            }).ToList();
        }
    }
}
