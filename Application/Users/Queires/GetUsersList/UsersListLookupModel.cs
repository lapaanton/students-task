
using students_task.Domain.Models;
using students_task.Domain.ValueObjects;

namespace students_task.Application.Users.Queiries.GetUsersList
{
    public class UsersListLookupModel 
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public Email Email {get;set;}
        public bool IsActive {get;set;}
        
        public UsersListLookupModel(students_task.Domain.Models.User _user)
        {
            this.Id = _user.UserId;
            this.Email =_user.Email;
            this.Name = _user.Name;
            this.IsActive = _user.IsActive;
        }
    }
}