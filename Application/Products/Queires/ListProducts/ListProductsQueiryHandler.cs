using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using students_task.Application.Interfaces;
using students_task.Application.Exceptions;
using students_task.Domain.Models;

namespace students_task.Application.Products.Queiries.ListProducts
{
    public class ListProductQueryHandler:IRequestHandler<ListProductsQueiry,List<ProductListViewModel>>
    {
        private IMyDbContext _context;
        public ListProductQueryHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<List<ProductListViewModel>> Handle(ListProductsQueiry request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.ToListAsync();
            if(products == null)
            {
                throw new System.Exception();
            }
            var productList = new List<ProductListViewModel>();
            products.ForEach(p => productList.Add(new ProductListViewModel(p)));
            return productList;
        }
    }
}