using MediatR;

namespace Test.MediatR.Boook.Commmands.BookCommmands
{
    public class RemoveBookCommand  :IRequest
    {
        public long Id { get; set; }
        public RemoveBookCommand(long id)
        {
            Id = id;
        }
    }
}
