using MediatR;

namespace students_task.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<UpdateProductViewModel>
    {
        public int? Id{ get; set; }
        public string Name{get;set;}
        public UpdateProductCommand(int id)
        {

        }
    }
}