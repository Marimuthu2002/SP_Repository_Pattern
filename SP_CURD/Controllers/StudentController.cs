using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP.BLL;
using SP.Entites;

namespace SP_CURD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent_BLL _stud_bll;
        public StudentController(IStudent_BLL bll)
        {
            _stud_bll=bll;
        }

        [HttpGet("GetAllData")]
        public IActionResult GetSpMethod()
        {
            return Ok(_stud_bll.getSpMethod());
        }

        [HttpPost("InsertNewStudDetails")]
        public IActionResult PostSpMethod(ViewModel studentDBModel)
        {
            return Ok(_stud_bll.PostSpMethod(studentDBModel));
        }

        [HttpPut("UpdateStudDetails")]

        public IActionResult PutSpMethod(StudentDBModel studentDBModel)
        {
            return Ok(_stud_bll.PutSpMethod(studentDBModel));
        }

        [HttpDelete("DeleteStudDetails")]
        public IActionResult DeleteSpMethod(int id)
        {
            return Ok(_stud_bll.DeleteSpMethod(id));
        }
    }
}
