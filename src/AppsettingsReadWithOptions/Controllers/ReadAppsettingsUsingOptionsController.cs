using AppsettingsReadWithOptions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppsettingsReadWithOptions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadAppsettingsUsingOptionsController : ControllerBase
    {
        private readonly AppsettingsOptionsModel _appSettingsModel;
        public ReadAppsettingsUsingOptionsController(IOptions<AppsettingsOptionsModel> options)
        {
            _appSettingsModel = options.Value;
        }

        [HttpGet("ReadConnString")]
        public IActionResult GetConnectionString()
        {
            return Ok(_appSettingsModel.DbConnString);
        }

        [HttpGet("ReadAppName")]
        public IActionResult GetAppName()
        {
            return Ok(_appSettingsModel.SubSettings.Name);
        }

        [HttpGet("ReadGroupDate")]
        public IActionResult GetGroupData()
        {
            return Ok(_appSettingsModel);
        }
    }
}
