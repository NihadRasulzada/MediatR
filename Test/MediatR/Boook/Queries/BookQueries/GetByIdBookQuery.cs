using MediatR;
using Test.MediatR.Boook.Results.BookResults;

namespace Test.MediatR.Boook.Queries.BookQueries
{
    public class GetByIdBookQuery  :IRequest<GetByIdBookQueryResult>
    {
        public long Id { get; set; }
        public GetByIdBookQuery(int id)
        {
            Id = id;

        }
    }
}
