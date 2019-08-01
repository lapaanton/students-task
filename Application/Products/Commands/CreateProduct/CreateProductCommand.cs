using MediatR;
using students_task.Domain.Models;


namespace students_task.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name{get; set; }

        public CreateProductCommand(string name)
        {
            this.Name = name;
        }
    }
}