using System.Threading;
using System.Threading.Tasks;
using MediatR;
using students_task.Application.Interfaces;
using students_task.Domain.Models;

namespace students_task.Application.Users.Command.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private IMyDbContext _context;
        public CreateUserCommandHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User{
                Name = request.Name,
                Email = request.Email,
                IsActive = request.isActive  
            };
            _context.Users.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.UserId;
        }
    }
}
