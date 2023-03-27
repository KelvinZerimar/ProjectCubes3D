namespace Cube3D.API.Services
{
    using Cube3D.API.ModelDTO;
    using Cube3D.Domain;
    public class CubeService : ICubeService
    {
        readonly ICubeDomain _domainICube;
        public CubeService(ICubeDomain domainICube)
        {
            _domainICube = domainICube ?? throw new ArgumentNullException(nameof(domainICube));
        }
        public Task<decimal> CalculateVolume(IEnumerable<CubeDTO> cubes)
        {
            CubeDTO[] cubesParam = cubes.ToArray();
            return _domainICube.CalculateVolume(cubesParam[0].Dimensiones, cubesParam[1].Dimensiones);
        }

        public Task<bool> DetermineCollide(IEnumerable<CubeDTO> cubes)
        {
            CubeDTO[] cubesParam = cubes.ToArray();
            return _domainICube.DetermineCollide(cubesParam[0].Dimensiones, cubesParam[1].Dimensiones);
        }
    }
}
