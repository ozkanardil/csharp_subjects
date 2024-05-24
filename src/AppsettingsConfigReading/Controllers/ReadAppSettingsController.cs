using AppsettingsConfigReading.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppsettingsConfigReading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadAppSettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ReadAppSettingsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ReadConnectionString")]
        public IActionResult GetConnectionString()
        {
            var connectionString = _configuration.GetValue<string>("ApplicationSettings:DbConnString");
            return Ok(connectionString);
        }

        [HttpGet("ReadApplicationName")]
        public IActionResult GetApplicationName()
        {
            var name = _configuration.GetValue<string>("ApplicationSettings:SubSettings:Name");
            return Ok(name);
        }

        [HttpGet("ReadApplicationGroupData")]
        public IActionResult ApplicationGroupData()
        {
            var appSettings = _configuration.GetSection("ApplicationSettings").Get<AppsettingsModel>();
            if (appSettings == null) return Ok(null);
            return Ok(appSettings);
        }

    }
}
