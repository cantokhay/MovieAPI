using MediatR;
using MovieAPI.Application.Features.Mediator.Results.TagResults;

namespace MovieAPI.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {
    }
}
