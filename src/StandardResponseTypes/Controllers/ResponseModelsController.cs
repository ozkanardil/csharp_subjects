using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StandardResponseTypes.Assets.Data;
using StandardResponseTypes.Assets.Models;

namespace StandardResponseTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseModelsController : ControllerBase
    {
        private List<UserModel> _userData = new List<UserModel>();
        public ResponseModelsController()
        {
            UserModel userModel = new UserModel();
            _userData = userModel.ListUsers();
        }

        [HttpGet("SuccessResponseWithoutData")]
        public IActionResult SuccessWithoutData()
        {
            return Ok(new SuccessRequestResult("Success response without data"));
        }

        [HttpGet("ErrorResponseWithoutData")]
        public IActionResult ErrorWithoutData()
        {
            return BadRequest(new ErrorRequestResult("Error response without data"));
        }

        [HttpGet("SuccessResponseWithData")]
        public IActionResult SuccessWithData()
        {
            return Ok(new SuccessRequestDataResult<List<UserModel>>(_userData, "Success response with data"));
        }

        [HttpGet("ErrorResponseWithData")]
        public IActionResult ErrrorWithData()
        {
            return Ok(new ErrorRequestDataResult<List<UserModel>>("Error response with data"));
        }
    }
}
