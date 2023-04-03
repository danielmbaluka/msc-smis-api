using Microsoft.AspNetCore.Mvc;
using SMIS.Models;
using SMIS.Services;

namespace SMIS.Controllers
{
    [Route("/api/v1/students")]
    public class StudentsController: ControllerBase
    {
        private readonly StudentService studentService;

        public StudentsController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await studentService.GetStudentsAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] Student student) 
        {
            if(ModelState.IsValid)
            {
                await studentService.CreateStudentAsync(student);
                return Ok(student);
            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }
    }
}
