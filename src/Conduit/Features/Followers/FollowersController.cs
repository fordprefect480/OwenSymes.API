using System.Threading.Tasks;
using OwenSymes.API.Features.Profiles;
using OwenSymes.API.Infrastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OwenSymes.API.Features.Followers
{
    [Route("profiles")]
    public class FollowersController : Controller
    {
        private readonly IMediator _mediator;

        public FollowersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("{username}/follow")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<ProfileEnvelope> Follow(string username)
        {
            return await _mediator.Send(new Add.Command(username));
        }

        [HttpDelete("{username}/follow")]
        [Authorize(AuthenticationSchemes = JwtIssuerOptions.Schemes)]
        public async Task<ProfileEnvelope> Unfollow(string username)
        {
            return await _mediator.Send(new Delete.Command(username));
        }
    }
}