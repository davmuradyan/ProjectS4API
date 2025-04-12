using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.CourseServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseCRUDService courseService;

        public CourseController(ICourseCRUDService courseService)
        {
            this.courseService = courseService;
        }

        [HttpPost("CreateCourse")]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseDto dto)
        {
            var result = await courseService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetCourse")]
        public async Task<IActionResult> GetCourse([FromQuery] int id)
        {
            var result = await courseService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllCourses")]
        public async Task<IActionResult> GetAllCourses()
        {
            var result = await courseService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateCourse")]
        public async Task<IActionResult> UpdateCourse([FromBody] UpdateCourseDto dto)
        {
            var result = await courseService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteCourse")]
        public async Task<IActionResult> DeleteCourse([FromQuery] int id)
        {
            var result = await courseService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}