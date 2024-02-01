using Aws_s3.Platform.Application.User.Commands;

namespace Aws_s3.Platform.Application
{
    public class UserAppService : IUserAppService
    {

        public Task<Guid> Add(AddUserCommand command, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
