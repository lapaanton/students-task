using students_task.Domain.Models;
using System.Collections.Generic;

namespace students_task.Application.Products.Queiries.GetProduct
{
    public class ProductViewModel
    {
        public string Name{get;set;}
        public ICollection<int> DepsIds;
        public ProductViewModel(Product _product)
        {
            this.Name = _product.Name;
            this.DepsIds = new HashSet<int>();
            foreach(var d in _product.Depts)
            {
                this.DepsIds.Add(d.DeptId);
            }
        }
    }
}