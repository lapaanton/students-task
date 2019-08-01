using System.Collections;
using System.Collections.Generic;
using MediatR;

namespace students_task.Application.Products.Queiries.ListProducts
{
    public class ListProductsQueiry : IRequest<List<ProductListViewModel>>
    {
    }
}