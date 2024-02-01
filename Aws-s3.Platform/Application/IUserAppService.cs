using Aws_s3.Platform.Application.User.Commands;

namespace Aws_s3.Platform.Application
{
    public interface IUserAppService
    {
        Task<Guid> Add(AddUserCommand command, CancellationToken cancellationToken = default);
    }
}
