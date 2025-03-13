using MediatR;
using MovieAPI.Application.Features.Mediator.Commands.CastCommands;
using MovieAPI.Domain.Entities.Enum;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.CastHandler
{
    public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
    {
        private readonly MovieContext _context;

        public RemoveCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Casts.FindAsync(request.Id);
            entity.DataStatus = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            await _context.SaveChangesAsync();
        }
    }
}
