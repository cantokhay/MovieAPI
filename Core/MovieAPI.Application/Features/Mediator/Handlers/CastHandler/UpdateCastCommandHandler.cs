using MediatR;
using MovieAPI.Application.Features.Mediator.Commands.CastCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.CastHandler
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var entity = _context.Casts.Find(request.Id);
            entity.CastBiography = request.CastBiography;
            entity.CastFirstName = request.CastFirstName;
            entity.CastLastName = request.CastLastName;
            entity.CastImageURL = request.CastImageURL;
            entity.CastOverview = request.CastOverview;
            entity.CastTitle = request.CastTitle;
            entity.CreatedDate = request.CreatedDate;
            entity.DataStatus = Domain.Entities.Enum.DataStatus.Modified;
            entity.ModifiedDate = DateTime.Now;
            entity.DeletedDate = null;
            await _context.SaveChangesAsync();
        }
    }
}
