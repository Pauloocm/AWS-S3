namespace Aws_s3.Platform.Domain.User
{
    public interface IUserRepository
    {
        Task Add(User user, CancellationToken cancellationToken);

        Task<List<User>> List(CancellationToken cancellationToken);
    }
}
