using MediatR;
using Test.MediatR.Boook.Results.BookResults;

namespace Test.MediatR.Boook.Queries.BookQueries
{
    public class GetBookQuery : IRequest<List<GetBookQueryResult>>
    {
    }
}
