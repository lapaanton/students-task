using System.Collections.Generic;
namespace students_task.Domain.Models{
    public class Product{
        public int ProductId {get; set;}
        public string Name {get; set;}
        public ICollection<Dept> Depts{ get; set; }
    }
}