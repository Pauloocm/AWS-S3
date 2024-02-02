using Aws_s3.Platform.Domain.User;
using Aws_s3.Platform.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Aws_s3.Platform.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dataContext;

        public UserRepository(DataContext context)
        {
            dataContext = context;
        }

        public async Task Add(User user, CancellationToken cancellationToken)
        {
            if(user is null)
                throw new ArgumentNullException(nameof(user));

            await dataContext.Users.AddAsync(user, cancellationToken);
            await dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<User>> List(CancellationToken cancellationToken)
        {
            return await dataContext.Users.ToListAsync(cancellationToken);
        }
    }
}
