using Microsoft.AspNetCore.Mvc;
using MediatR;
using MovieAPI.Application.Features.Mediator.Queries.TagQueries;
using MovieAPI.Application.Features.Mediator.Commands.TagCommands;

namespace MovieAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var result = await _mediator.Send(new GetTagQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Created succesfully");
        }

        [HttpGet("GetTag")]
        public async Task<IActionResult> GetTag(int id)
        {
            var result = await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
            await _mediator.Send(new RemoveTagCommand(id));
            return Ok("Deleted succesfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Updated succesfully");
        }
    }
}
