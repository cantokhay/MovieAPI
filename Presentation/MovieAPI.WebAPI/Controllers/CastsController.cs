using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Application.Features.Mediator.Commands.CastCommands;
using MovieAPI.Application.Features.Mediator.Queries.CastQueries;
using System.Threading.Tasks;

namespace MovieAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CastList() 
        {
            var value = await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Created succesfully");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCast(int id)
        {
            await _mediator.Send(new RemoveCastCommand(id));
            return Ok("Deleted succesfully");
        }

        [HttpGet("GetCastById")]
        public async Task<IActionResult> GetCastById(int id)
        {
            var value = await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Updated succesfully");
        }
    }
}
