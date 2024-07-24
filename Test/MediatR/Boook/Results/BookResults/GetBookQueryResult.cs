using Test.Enums;

namespace Test.MediatR.Boook.Results.BookResults
{
    public class GetBookQueryResult
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BookGenre BookGenre { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
