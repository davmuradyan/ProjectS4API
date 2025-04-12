using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.CoursePrerequisiteServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class CoursePrerequisiteController : ControllerBase
    {
        private readonly ICoursePrerequisiteCRUDService coursePrerequisiteService;

        public CoursePrerequisiteController(ICoursePrerequisiteCRUDService coursePrerequisiteService)
        {
            this.coursePrerequisiteService = coursePrerequisiteService;
        }

        [HttpPost("CreateCoursePrerequisite")]
        public async Task<IActionResult> CreateCoursePrerequisite([FromBody] CreateCoursePrerequisiteDto dto)
        {
            var result = await coursePrerequisiteService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetCoursePrerequisite")]
        public async Task<IActionResult> GetCoursePrerequisite([FromQuery] int id)
        {
            var result = await coursePrerequisiteService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllCoursePrerequisites")]
        public async Task<IActionResult> GetAllCoursePrerequisites()
        {
            var result = await coursePrerequisiteService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateCoursePrerequisite")]
        public async Task<IActionResult> UpdateCoursePrerequisite([FromBody] UpdateCoursePrerequisiteDto dto)
        {
            var result = await coursePrerequisiteService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteCoursePrerequisite")]
        public async Task<IActionResult> DeleteCoursePrerequisite([FromQuery] int id)
        {
            var result = await coursePrerequisiteService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}