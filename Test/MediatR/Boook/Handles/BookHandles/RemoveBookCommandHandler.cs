using MediatR;
using Test.Context;
using Test.Entities;
using Test.MediatR.Boook.Commmands.BookCommmands;

namespace Test.MediatR.Boook.Handles.BookHandles
{
    public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand>
    {
        private readonly AppDbContext _context;

        public RemoveBookCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _context.Books.FindAsync(request.Id);

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
