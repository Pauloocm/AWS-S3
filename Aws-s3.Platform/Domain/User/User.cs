using System.ComponentModel.DataAnnotations;

namespace Aws_s3.Platform.Domain.User
{
    public class User
    {
        public User(string name, string email)
        {
            if(name == null) throw new ArgumentNullException("name");
            if(email == null) throw new ArgumentNullException("email");

            Name = name;
            Email = email;
        }

        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

    }
}
