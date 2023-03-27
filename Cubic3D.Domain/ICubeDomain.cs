
namespace Cube3D.Domain
{
    public interface ICubeDomain
    {
        Task<decimal> CalculateVolume(string paramCubeOne, string paramCubeTwo);
        Task<bool> DetermineCollide(string paramCubeOne, string paramCubeTwo);
    }
}
