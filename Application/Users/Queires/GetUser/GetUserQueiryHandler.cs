using MediatR;
using System.Threading.Tasks;
using System.Threading;
using students_task.Application.Interfaces;
using students_task.Application.Exceptions;
using students_task.Domain.Models;

namespace students_task.Application.Users.Queiries.GetUser
{
    public class GetUserQueiryHandler : IRequestHandler<GetUserQueiry, UserViewModel>
    {
        private IMyDbContext _context;
        public GetUserQueiryHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<UserViewModel> Handle(GetUserQueiry request, CancellationToken CancellationToken)
        {
            var entity = await _context.Users.FindAsync(request.UserId);
            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.UserId.ToString());
            }
            return new UserViewModel(entity);
        }
    }
}