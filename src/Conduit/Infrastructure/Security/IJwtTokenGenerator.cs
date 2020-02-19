using System.Threading.Tasks;

namespace OwenSymes.API.Infrastructure.Security
{
    public interface IJwtTokenGenerator
    {
        Task<string> CreateToken(string username);
    }
}