using Cube3D.API.ModelDTO;

namespace Cube3D.API.Services
{
    public interface ICubeService
    {
        Task<bool> DetermineCollide(IEnumerable<CubeDTO> cubes);
        Task<decimal> CalculateVolume(IEnumerable<CubeDTO> cubes);
    }
}
