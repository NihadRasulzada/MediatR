using MediatR;
using Microsoft.EntityFrameworkCore;
using Test.Context;
using Test.Entities;
using Test.MediatR.Boook.Queries.BookQueries;
using Test.MediatR.Boook.Results.BookResults;

namespace Test.MediatR.Boook.Handles.BookHandles
{
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQuery, GetByIdBookQueryResult>
    {
        private readonly AppDbContext _context;

        public GetByIdBookQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GetByIdBookQueryResult> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            Book book = await _context.Books.FindAsync(request.Id);
            return new()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                BookGenre = book.BookGenre,
                Created = book.Created,
                Updated = book.Updated,
            };
        }
    }

}
