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

        public async Task<Guid> Add(AddUserCommand command, CancellationToken cancellationToken = default)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));

            var user = new User(command.Name, command.Email);

            if (user == null)
                throw new ArgumentNullException($"{user} is null");

            await userRepository.Add(user, cancellationToken);

            return user.Id;
        }

        public async Task<List<User>> List(CancellationToken cancellationToken = default)
        {
            return await userRepository.List(cancellationToken);
        }
    }
}
