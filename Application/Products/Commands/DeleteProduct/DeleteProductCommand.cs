using MediatR;

namespace students_task.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int Id{get;set;}
        public DeleteProductCommand(int id)
        {
            this.Id = id;
        }
    }
}