using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.PlandeCours.PlanDeCoursServices;

namespace ProjectS4API.Controllers.PlanDeCours {
    public class PlanDeCoursController : Controller {
        private readonly IPlanDeCours service;

        public PlanDeCoursController(IPlanDeCours courseService) {
            this.service = courseService;
        }

        [HttpGet("GetPdC")]
        public async Task<IActionResult> GetPlanDeCours([FromQuery] int id) {
            var result = await service.GetPlanDeCours(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
