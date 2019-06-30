using MediatR;
using students_task.Domain.ValueObjects;

namespace students_task.Application.Users.Command.DeleteUser
{
    public class DeleteUserCommand : IRequest
    {
        public int UserId{ get; set; }
    }
}