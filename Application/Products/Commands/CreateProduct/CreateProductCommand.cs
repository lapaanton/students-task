using MediatR;

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