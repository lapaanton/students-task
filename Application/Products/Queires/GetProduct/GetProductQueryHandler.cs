using MediatR;
using System.Threading;
using System.Threading.Tasks;
using students_task.Application.Interfaces;
using students_task.Application.Exceptions;
using students_task.Domain.Models;

namespace students_task.Application.Products.Queiries.GetProduct
{
    public class GetProductQueryHandler:IRequestHandler<GetProductQueiry,ProductViewModel>
    {
        private IMyDbContext _context;
        public GetProductQueryHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<ProductViewModel> Handle(GetProductQueiry request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if(product == null)
            {
                throw new NotFoundException(nameof(Product), request.Id.ToString());
            }

            return new ProductViewModel(product);
        }
    }
}