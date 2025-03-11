using MediatR;
using MovieAPI.Domain.Entities.Enum;

namespace MovieAPI.Application.Features.Mediator.Commands.CastCommands
{
    public class CreateCastCommand : IRequest
    {
        public DataStatus DataStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public string CastTitle { get; set; }
        public string CastFirstName { get; set; }
        public string CastLastName { get; set; }
        public string CastImageURL { get; set; }
        public string? CastOverview { get; set; }
        public string? CastBiography { get; set; }
    }
}
