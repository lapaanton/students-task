using System.Collections;
using System.Collections.Generic;
using students_task.Domain.Models;

namespace students_task.Application.Products.Queiries.ListProducts
{
    public class ProductListViewModel
    {
        public int ProductId{get;set;}
        public string ProductName{get;set;}
        public List<int> Depts{get;}
        public ProductListViewModel(Product product)
        {
            this.ProductId = product.ProductId;
            this.ProductName = product.Name;
            this.Depts = new List<int>();
            if (product.Depts != null)
            {
                foreach (var item in product.Depts)
                {
                    this.Depts.Add(item.DeptId);
                }
            }

        }
    }
}