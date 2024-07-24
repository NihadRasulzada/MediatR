using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Context;
using Test.MediatR.Boook.Commmands.BookCommmands;
using Test.MediatR.Boook.Queries.BookQueries;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BookGet()
        {
            return Ok(await _mediator.Send(new GetBookQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> BookCreate(CreateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("Book Added");
        }

        [HttpPut]
        public async Task<IActionResult> BookUpdate(UpdateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("Book Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> BookDelete(int id)
        {
            await _mediator.Send(new RemoveBookCommand(id));
            return Ok("Book Deleted");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BookGetById(int id)
        {
            return Ok(await _mediator.Send(new GetByIdBookQuery(id)));
        }
    }
}
