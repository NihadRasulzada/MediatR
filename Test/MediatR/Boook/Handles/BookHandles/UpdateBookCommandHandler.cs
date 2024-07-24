using MediatR;
using Test.Context;
using Test.Entities;
using Test.MediatR.Boook.Commmands.BookCommmands;

namespace Test.MediatR.Boook.Handles.BookHandles
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly AppDbContext _context;

        public UpdateBookCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            Book book = await _context.Books.FindAsync(request.Id);
            book.Title = request.Title;
            book.Description = request.Description;
            book.BookGenre = request.BookGenre;
            book.Updated = request.Updated;
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }
    }
}
