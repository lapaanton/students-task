using students_task.Domain.Models;
using MediatR;

namespace students_task.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductViewModel
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public UpdateProductViewModel(Product product)
        {
            this.Id = product.ProductId;
            this.Name = product.Name;
        }
    }
}