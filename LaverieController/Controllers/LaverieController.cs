using LaverieController.Modele.Business;
using Microsoft.AspNetCore.Mvc;

namespace LaverieController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaverieController : Controller
    {
        private readonly LaverieBusiness _business;

        public LaverieController(LaverieBusiness business)
        {
            _business = business;
        }

        [HttpGet("total_laverie/{laverieId}")]
        public IActionResult GetTotalCostForLaverieToday(int laverieId)
        {
            try
            {
                float totalCost = _business.GetTotalCostForLaverieToday(laverieId);
                return Ok(new { LaverieId = laverieId, TotalCost = totalCost });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
