using System.ComponentModel.DataAnnotations;

namespace Aws_s3.Platform.Application.Users.Commands
{
    public class AddUserCommand
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
