using System.Threading.Tasks;
using System.Threading;
using System;
using MediatR;
using students_task.Application.Interfaces;
using students_task.Application.Exceptions;

namespace students_task.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductViewModel>
    {
        private IMyDbContext _context;
        public UpdateProductCommandHandler(IMyDbContext context)
        {
            _context = context;
        }
        public async Task<UpdateProductViewModel> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            if(request.Id==null || !request.Id.HasValue)
            {
                throw new ArgumentNullException(nameof(request.Id), "Id must not be null");
            }
            var product = await _context.Products.FindAsync(request.Id.Value);
            if(product == null){
                throw new NotFoundException(nameof(request.Id), "Prodct with this id not found");
            }
            if(request.Name != null){
                product.Name = request.Name;
            }
            _context.Products.UpdateRange(product);
            await _context.SaveChangesAsync(cancellationToken);
            return new UpdateProductViewModel(product);
        }
    }
}