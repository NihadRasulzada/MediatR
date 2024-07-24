using MediatR;
using Microsoft.EntityFrameworkCore;
using Test.Context;
using Test.Entities;
using Test.MediatR.Boook.Queries.BookQueries;
using Test.MediatR.Boook.Results.BookResults;

namespace Test.MediatR.Boook.Handles.BookHandles
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, List<GetBookQueryResult>>
    {
        private readonly AppDbContext _context;

        public GetBookQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetBookQueryResult>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            List<Book> books = await _context.Books.ToListAsync();
            return books.Select(x => new GetBookQueryResult
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                BookGenre = x.BookGenre,
                Created = x.Created,
                Updated = x.Updated,
            }).ToList();
        }
    }
}
