using MediatR;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using students_task.Application.Interfaces;
using students_task.Domain.Models;

namespace students_task.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private IMyDbContext _context;
        public CreateProductCommandHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product{
                Name = request.Name,
                Depts = new List<Dept>()
            };
            _context.Products.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.ProductId;
        }
    }
}