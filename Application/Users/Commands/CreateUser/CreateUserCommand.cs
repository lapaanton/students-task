using MediatR;
using students_task.Domain.ValueObjects;

namespace students_task.Application.Users.Command.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Name{ get; set; }
        public Email Email{ get; set; }
        public bool isActive{ get; set; }

    }
}