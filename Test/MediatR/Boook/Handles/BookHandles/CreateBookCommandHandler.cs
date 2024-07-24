using MediatR;
using Test.Context;
using Test.MediatR.Boook.Commmands.BookCommmands;

namespace Test.MediatR.Boook.Handles.BookHandles
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly AppDbContext _context;

        public CreateBookCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _context.Books.AddAsync(new()
            {
                Title = request.Title,
                BookGenre = request.BookGenre,
                Created = request.Created,
                Description = request.Description
            });
            await _context.SaveChangesAsync();
        }
    }
}
