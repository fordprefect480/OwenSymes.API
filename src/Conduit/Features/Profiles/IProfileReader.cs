using System.Threading.Tasks;

namespace OwenSymes.API.Features.Profiles
{
    public interface IProfileReader
    {
        Task<ProfileEnvelope> ReadProfile(string username);
    }
}