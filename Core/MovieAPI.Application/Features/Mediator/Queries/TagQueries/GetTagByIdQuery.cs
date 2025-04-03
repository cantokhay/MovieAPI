using MediatR;
using MovieAPI.Application.Features.Mediator.Results.TagResults;

namespace MovieAPI.Application.Features.Mediator.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTagByIdQuery(int id)
        {
            Id = id;
        }
    }
}
