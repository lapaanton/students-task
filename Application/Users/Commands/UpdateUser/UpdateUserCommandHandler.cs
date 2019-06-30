using System.Threading;
using System.Threading.Tasks;
using MediatR;
using students_task.Application.Interfaces;
using students_task.Domain.Models;
using students_task.Application.Exceptions;

namespace students_task.Application.Users.Command.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private IMyDbContext _context;
        public UpdateUserCommandHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Users.FindAsync(request.UserId);
            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.UserId.ToString());
            }
            entity.Email = request.Email;
            entity.IsActive = (!request.isActive.HasValue)? entity.IsActive:request.isActive.Value;
            entity.Name = request.Name;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
