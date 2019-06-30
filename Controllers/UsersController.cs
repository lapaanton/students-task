using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using students_task.Application.Users.Queiries.GetUsersList;
using students_task.Application.Users.Command.CreateUser;
using students_task.Application.Users.Command.DeleteUser;
using students_task.Application.Users.Command.UpdateUser;

namespace students_task.Controllers
{
    [Route("api/users/")]
    [ApiController]
    public class UsersController : BaseController
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<UsersListViewModel>> Get()
        {
            
            return await Mediator.Send(new GetUsersListQueiry());
        }

        // GET api/users/39
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /*// POST api/users/create
        [HttpPost("create")]*/
        
        //PUT api/users/
        [HttpPut]
        public async Task<ActionResult<int>> Post([FromBody] CreateUserCommand cmd)
        {
            return await Mediator.Send(cmd);
        }

        // POST api/users/39
        [HttpPost("{id}")]
        public async void Update(int id, [FromBody] UpdateUserCommand cmd)
        {
            cmd.UserId = id;
            await Mediator.Send(cmd);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await Mediator.Send(new DeleteUserCommand(id));
        }
    }
}