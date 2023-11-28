using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Apis.Controllers
{
    [Route("api/[Controller]")] // Route 
    public class TodosController : ControllerBase // ControllerBase : using Microsoft.AspNetCore.Mvc;
    {
        private readonly ITodoRepository _repository;
        public TodosController()
        {
            _repository = new TodoRepositoryJson();
            
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //return Content("안녕하세여");
            return Ok(_repository.GetAll());
        }
        [HttpPost] // Web => APP
        public IActionResult Add([FromBody]Todo dto )
        {
            _repository.Add(dto);
            return Ok(dto);
        }
    }
}
