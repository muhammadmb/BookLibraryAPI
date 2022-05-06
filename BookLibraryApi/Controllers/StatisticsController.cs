using BookLibraryApi.Repositories.StatisticsRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("api/statistics")]
    [EnableCors("demoPolicy")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;
        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository ??
                throw new ArgumentNullException(nameof(statisticsRepository));
        }

        [HttpGet()]
        public async Task<IActionResult> GetStatistics()
        {
            var statistics = await _statisticsRepository.GetStatistics();

            return Ok(statistics);
        }

        [HttpGet("Books")]
        public async Task<IActionResult> getBooksStatistics()
        {
            var sts = await _statisticsRepository.GetBooksStatistics();

            return Ok(sts);
        }
    }
}
