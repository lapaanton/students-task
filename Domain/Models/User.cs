using System.Collections.Generic;
using students_task.Domain.ValueObjects;

namespace students_task.Domain.Models
{
    public class User{
        public User(){
            Depts = new HashSet<Dept>();
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Dept> Depts{ get; private set; }
        
    }
}