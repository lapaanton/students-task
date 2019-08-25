using MediatR;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using students_task.Application.Products.Queiries.GetProduct;
using students_task.Application.Products.Queiries.ListProducts;
using students_task.Application.Products.Commands.CreateProduct;
using students_task.Application.Products.Commands.DeleteProduct;
using students_task.Application.Products.Commands.UpdateProduct;
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
        [HttpPost("{id}")]
        public async Task<ActionResult<UpdateProductViewModel>> Update(int id, [FromBody]UpdateProductCommand request){
            request.Id = id;
            return await Mediator.Send(request);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id){
            return await Mediator.Send(new DeleteProductCommand(id));
        }
    }
}