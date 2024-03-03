using Data;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_8.Controllers
{
    [Route("api/recordlabels")]
    [ApiController]
    public class RecordLabelApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RecordLabelApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFiltered(string filter)
        {
            return Ok(_context.RecordLabels
                .Where(o => o.Name.StartsWith(filter))
                .Select(o => new { o.Name, o.Id })
                .ToList());
        }
    }
}
