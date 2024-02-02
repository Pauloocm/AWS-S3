using System.ComponentModel.DataAnnotations;

namespace Aws_s3.Platform.Domain.User
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

    }
}
