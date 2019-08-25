using MediatR;
using System.Threading;
using System.Threading.Tasks;
using students_task.Application.Interfaces;
using students_task.Application.Exceptions;
using students_task.Domain.Models;

namespace students_task.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private IMyDbContext _context;
        public DeleteProductCommandHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if(product == null)
            {
                throw new NotFoundException(nameof(Product),request.Id.ToString());
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}