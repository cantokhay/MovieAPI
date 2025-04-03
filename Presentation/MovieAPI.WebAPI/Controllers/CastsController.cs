using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Application.Features.Mediator.Commands.CastCommands;
using MovieAPI.Application.Features.Mediator.Queries.CastQueries;

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
        public IActionResult CastList() 
        {
            var value = _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCast(CreateCastCommand command)
        {
            var value = _mediator.Send(command);
            return Ok("Created succesfully");
        }

        [HttpDelete]
        public IActionResult DeleteCast(int id)
        {
            var value = _mediator.Send(new RemoveCastCommand(id));
            return Ok("Deleted succesfully");
        }

        [HttpGet("GetCastById")]
        public IActionResult GetCastById(int id)
        {
            var value = _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCast(UpdateCastCommand command)
        {
            var value = _mediator.Send(command);
            return Ok("Updated succesfully");
        }
    }
}
