namespace Cubic3D.API.Controllers
{
    using Cube3D.API.ModelDTO;
    using Cube3D.API.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController, Produces("application/json")]
    public class CubeController : Controller
    {
        private readonly ILogger<CubeController> _logger;
        private readonly ICubeService _serviceICube;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="serviceICube"></param>
        public CubeController(ILogger<CubeController> logger, ICubeService serviceICube)
        {
            _logger = logger;
            _serviceICube = serviceICube;
        }

        /// <summary>
        /// Determine whether the two objects collide
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = nameof(Collide))]
        public async Task<IActionResult> Collide([FromBody] IEnumerable<CubeDTO> cube)
        {
            _logger.LogInformation("");

            var result = await _serviceICube.DetermineCollide(cube);
            return Ok(result);
        }

        /// <summary>
        /// Calculate the intersected volume.
        /// </summary>
        /// <returns></returns>
        [HttpPut(Name = nameof(CalculateVolume))]
        public async Task<IActionResult> CalculateVolume([FromBody] IEnumerable<CubeDTO> cube)
        {
            _logger.LogInformation("");

            var result = await _serviceICube.CalculateVolume(cube);
            return Ok(result);
        }
    }

}
