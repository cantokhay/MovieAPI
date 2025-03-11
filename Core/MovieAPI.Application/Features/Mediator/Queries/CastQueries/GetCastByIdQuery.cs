using MediatR;
using MovieAPI.Application.Features.Mediator.Results.CastResults;

namespace MovieAPI.Application.Features.Mediator.Queries.CastQueries
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCastByIdQuery(int id)
        {
            Id = id;
        }
    }
}
