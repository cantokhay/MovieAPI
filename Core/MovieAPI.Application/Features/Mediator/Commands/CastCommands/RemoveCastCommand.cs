using MediatR;

namespace MovieAPI.Application.Features.Mediator.Commands.CastCommands
{
    public class RemoveCastCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveCastCommand(int id)
        {
            Id = id;
        }
    }
}
