using Aws_s3.Platform.Application.Users.Commands;
using Aws_s3.Platform.Domain.User;

namespace Aws_s3.Platform.Application
{
    public interface IUserAppService
    {
        Task<Guid> Add(AddUserCommand command, CancellationToken cancellationToken = default);
        Task<List<User>> List(CancellationToken cancellationToken = default);
    }
}
