using MediatR;

namespace students_task.Application.Users.Queiries.GetUser
{
    public class GetUserQueiry : IRequest<UserViewModel>
    {
        public int UserId { get; set; }

        public GetUserQueiry(int id)
        {
            this.UserId = id;
        }
    }
}