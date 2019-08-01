using students_task.Domain.Models;
using System.Collections.Generic;
namespace students_task.Application.Users.Queiries.GetUser
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public ICollection<int> DeptIds;
        public UserViewModel(User _user)
        {
            this.UserId = _user.UserId;
            this.Name = _user.Name;
            this.Email = _user.Email;
            this.IsActive = _user.IsActive;
            this.DeptIds = new HashSet<int>();
            foreach(var d in _user.Depts)
            {
                DeptIds.Add(d.DeptId);
            }
        }
    }
}