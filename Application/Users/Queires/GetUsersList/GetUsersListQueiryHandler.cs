
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using students_task.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace students_task.Application.Users.Queiries.GetUsersList
{
    public class GetUsersListQueiryHandler : IRequestHandler<GetUsersListQueiry,UsersListViewModel>
    {
        private IMyDbContext _context;
    
        public GetUsersListQueiryHandler(IMyDbContext context )
        {
            this._context = context;
        }
        public async Task<UsersListViewModel> Handle(GetUsersListQueiry queiry,CancellationToken cancellationToken)
        {
            var users = await _context.Users.ToListAsync();
            var _users = new List<UsersListLookupModel>();
            users.ForEach(user => _users.Add(new UsersListLookupModel(user)));
            return new UsersListViewModel{
                Users = _users
            };
        }
    }
}