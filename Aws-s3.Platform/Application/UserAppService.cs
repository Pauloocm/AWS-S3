using Aws_s3.Platform.Application.Users.Commands;
using Aws_s3.Platform.Domain.User;

namespace Aws_s3.Platform.Application
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository userRepository;

        public UserAppService(IUserRepository UserRepository)
        {
            userRepository = UserRepository;
        }

        public Task<Guid> Add(AddUserCommand command, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> List(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
