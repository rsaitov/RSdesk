using Microsoft.AspNetCore.Mvc;
using SureDesk.Data;

namespace SureDesk.Controllers
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