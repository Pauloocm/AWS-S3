using Aws_s3.Platform.Application;
using Aws_s3.Platform.Application.Users.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Aws_s3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService userAppService;

        public UsersController(IUserAppService userService)
        {
            userAppService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddUserCommand command, CancellationToken cancellationToken)
        {
            if (command is null)
                throw new ArgumentNullException(nameof(command));

            var userId = await userAppService.Add(command, cancellationToken);

            return Ok(userId);
        }

        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            return Ok(await userAppService.List(cancellationToken));
        }
    }
}
