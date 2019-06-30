using MediatR;
using students_task.Domain.ValueObjects;

namespace students_task.Application.Users.Command.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        public int UserId{ get; set; }
        public string Name{ get; set; }
        public Email Email{ get; set; }
        public bool? isActive{ get; set; }
    }
}