using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
                .Where(o => EF.Functions.Like(o.Name, $"{filter}%"))
                .Select(o => new { o.Name, o.Id })
                .ToList());
        }

    }
}
