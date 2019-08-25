using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using students_task.Application.Products.Queiries.GetProduct;
using students_task.Application.Exceptions;

namespace students_task.Controllers
{
    [Route("api/depts/")]
    [ApiController]
    public class DeptsController : BaseController
    {
        // GET api/users/39
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
    }
}