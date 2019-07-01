using students_task.Domain.Models;
namespace students_task.Application.Users.Queiries.GetUser
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public UserViewModel(User _user)
        {
            this.UserId = _user.UserId;
            this.Name = _user.Name;
            this.Email = _user.Email;
            this.IsActive = _user.IsActive;
        }
    }
}