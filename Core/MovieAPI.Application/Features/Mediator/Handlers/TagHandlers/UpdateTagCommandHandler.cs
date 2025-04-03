using MediatR;
using MovieAPI.Application.Features.Mediator.Commands.TagCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieContext _context;

        public UpdateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var entity = _context.Tags.Find(request.Id);
            entity.TagTitle = request.TagTitle;
            entity.CreatedDate = request.CreatedDate;
            entity.DataStatus = Domain.Entities.Enum.DataStatus.Modified;
            entity.ModifiedDate = DateTime.Now;
            entity.DeletedDate = null;
            await _context.SaveChangesAsync();
        }
    }
}
