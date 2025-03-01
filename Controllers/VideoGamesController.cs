using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRUEBA_DAPPER.Models;
using PRUEBA_DAPPER.Repositories;

namespace PRUEBA_DAPPER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public VideoGamesController(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllAsync()
        {
            var videoGames = await _videoGameRepository.GetAllAsync();
            return Ok(videoGames);
        }

    }
}
