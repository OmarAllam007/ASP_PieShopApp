using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PieShopApp.Models;

namespace PieShopApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPieRepository _pieRepository;

        public SearchController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var pies = _pieRepository.AllPies;
            return Ok(pies);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            
            if (pie == null)
            {
                return NotFound();
            }
            
            return Ok(_pieRepository.AllPies.Where(p => p.PieId == id));
        }

        [HttpPost]
        public IActionResult Search([FromBody] string searchQuery)
        {
            IEnumerable<Pie> pies = new List<Pie>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                pies = _pieRepository.Search(searchQuery);
            }

            return new JsonResult(pies);
        }
    }
}
