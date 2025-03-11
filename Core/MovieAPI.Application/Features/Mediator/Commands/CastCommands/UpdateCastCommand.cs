using MediatR;

namespace MovieAPI.Application.Features.Mediator.Commands.CastCommands
{
    public class UpdateCastCommand : IRequest
    {
        public int Id { get; set; }

        public UpdateCastCommand(int id)
        {
            Id = id;
        }
    }
}
