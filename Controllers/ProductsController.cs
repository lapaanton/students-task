using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using students_task.Application.Products.Queiries.GetProduct;
using students_task.Application.Products.Queiries.ListProducts;
using students_task.Application.Products.Commands.CreateProduct;
using students_task.Application.Exceptions;

namespace students_task.Controllers
{
    [Route("api/products/")]
    [ApiController]
    public class ProductsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IList<ProductListViewModel>>> Get(){
            return await Mediator.Send(new ListProductsQueiry());
        }

        // GET api/products/39
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductViewModel>> Get(int id)
        {
            try
            {
                return await Mediator.Send(new GetProductQueiry(id));
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex);
            }
            
        }
        
        [HttpPut]
        public async Task<ActionResult<int>> Create([FromBody]CreateProductCommand request){
            return await Mediator.Send(request);
        }
    }
}