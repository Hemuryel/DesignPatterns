using MediatR;

namespace DDGofMediator.Domain.Student.Command
{
    public class StudentDeleteCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
