using Code_First.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        private readonly CodeFirstContext _context;

        public AdministratorController(CodeFirstContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAdministrators")]
    }
}
