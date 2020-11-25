using Microsoft.AspNetCore.Mvc;

namespace Liberis.Analyzer.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
