using MediatR;
using MovieAPI.Application.Features.Mediator.Results.CastResults;

namespace MovieAPI.Application.Features.Mediator.Queries.CastQueries
{
    public class GetCastQuery : IRequest<List<GetCastQueryResult>>
    {

    }
}
