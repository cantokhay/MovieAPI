using Microsoft.AspNetCore.Identity;
using MovieAPI.Application.Features.CQRS.Commands.UserRegisterCommands;
using MovieAPI.Persistance.Context;
using MovieAPI.Persistance.Identity;

namespace MovieAPI.Application.Features.CQRS.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler
    {
        private readonly MovieContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CreateUserRegisterCommandHandler(MovieContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task Handle(CreateUserRegisterCommand command) 
        {
            var user = new AppUser()
            {
                Name = command.Name,
                Surname = command.Surname,
                UserName = command.UserName,
                Email = command.Email
            };
            var result = await _userManager.CreateAsync(user, command.Password);
            //result ile hata kontrolü yapılabilmesi için bıraktım.
        }
    }
}
