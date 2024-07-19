using Microsoft.AspNetCore.Mvc;
using ServerStatusAPI.Models;
using ServerStatusAPI.Services;

namespace ServerStatusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerStatusController : ControllerBase
    {
        private readonly ServerStatusService _serverStatusService;

        public ServerStatusController(ServerStatusService serverStatusService)
        {
            _serverStatusService = serverStatusService;
        }

        [HttpGet]
        public ActionResult<ServerStatus> Get()
        {
            var status = _serverStatusService.GetServerStatus();
            return Ok(status);
        }
    }
}
