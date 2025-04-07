using MediatR;
using MovieAPI.Application.Features.Mediator.Commands.TagCommands;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly MovieContext _context;

        public CreateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            await _context.Tags.AddAsync(new()
            {
                TagTitle = request.TagTitle,
                CreatedDate = DateTime.Now,
                DataStatus = request.DataStatus,
                DeletedDate = null,
                ModifiedDate = null
            });
            await _context.SaveChangesAsync();
        }
    }
}
