using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/")]
    public class HelpController : BaseApi
    {
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return Redirect(string.Format("{0}help/index", Request.GetDisplayUrl()));
        }

        [HttpGet, Route("healthcheck")]
        public IActionResult Ping()
        {
            var id = CurrentUserId;
            return Ok();
        }
    }
}