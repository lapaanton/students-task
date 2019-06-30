using System.Threading;
using System.Threading.Tasks;
using MediatR;
using students_task.Application.Interfaces;
using students_task.Domain.Models;
using students_task.Application.Exceptions;

namespace students_task.Application.Users.Command.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private IMyDbContext _context;
        public DeleteUserCommandHandler(IMyDbContext context)
        {
            this._context = context;
        }
        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Users.FindAsync(request.UserId);
            if (entity == null){
                throw new NotFoundException(nameof(User), request.UserId.ToString());
            }
            _context.Users.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
