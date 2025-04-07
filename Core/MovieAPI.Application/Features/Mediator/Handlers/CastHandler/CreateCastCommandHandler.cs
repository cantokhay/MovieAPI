using MediatR;
using MovieAPI.Application.Features.Mediator.Commands.CastCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.CastHandler
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;

        public CreateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            await _context.Casts.AddAsync(new()
            {
                CastBiography = request.CastBiography,
                CastFirstName = request.CastFirstName,
                CastLastName = request.CastLastName,
                CastImageURL = request.CastImageURL,
                CastOverview = request.CastOverview,
                CastTitle = request.CastTitle,
                CreatedDate = DateTime.Now,
                DataStatus = request.DataStatus,
                DeletedDate = null,
                ModifiedDate = null
            });
            await _context.SaveChangesAsync();
        }
    }
}
