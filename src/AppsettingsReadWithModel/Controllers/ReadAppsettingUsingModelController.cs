using AppsettingsReadWithModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppsettingsReadWithModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadAppsettingUsingModelController : ControllerBase
    {

        [HttpGet("ReadConnString")]
        public IActionResult GetConnectionString()
        {
            var connString = ApplicationSettings.DbConnString;
            return Ok(connString);
        }

        [HttpGet("ReadAppName")]
        public IActionResult GetAppName()
        {
            var connString = ApplicationSettings.SubSettings.Name;
            return Ok(connString);
        }

        [HttpGet("ReadGroup")]
        public IActionResult GetGroup()
        {
            var subSettings = ApplicationSettings.SubSettings;
            return Ok(subSettings);
        }
    }
}
