using MediatR;

namespace students_task.Application.Products.Queiries.GetProduct
{
    public class GetProductQueiry : IRequest<ProductViewModel>
    {
        public int Id { get; set; }
        public GetProductQueiry(int id)
        {
            this.Id = id;
        }
    }
}