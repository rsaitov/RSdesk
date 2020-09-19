using Microsoft.AspNetCore.Mvc;
using RSdesk.Data;

namespace RSdesk.Controllers
{
    [Route("api/tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepo _repository;

        public TicketController(ITicketRepo repository)
        {
            _repository = repository;
        }
    }
}