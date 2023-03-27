
namespace Cube3D.Domain
{
    public class CubeDomain : ICubeDomain
    {
        public async Task<decimal> CalculateVolume(string paramCubeOne, string paramCubeTwo)
        {
            // TODO: calculate the intersected volume
            await Task.Delay(1000);
            return Math.Round(Decimal.Divide(10, 20) * 100, 2);
        }

        public async Task<bool> DetermineCollide(string paramCubeOne, string paramCubeTwo)
        {
            // TODO: determine whether the two objects collide
            await Task.Delay(1000);
            return true;
        }
    }
}
