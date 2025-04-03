using MediatR;
using MovieAPI.Application.Features.Mediator.Commands.TagCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieContext _context;

        public RemoveTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tags.FindAsync(request.Id);
            entity.DataStatus = Domain.Entities.Enum.DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            await _context.SaveChangesAsync();
        }
    }
}
