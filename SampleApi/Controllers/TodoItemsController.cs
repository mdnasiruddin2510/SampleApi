using Microsoft.AspNetCore.Mvc;
using SampleApi.Moddels;

namespace SampleApi.Controllers
{
    [Route("api/TodoItems")]
    [ApiController]
    public class TodoItemsController : Controller
    {
        private readonly TodoContext _context;
        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetTodoItems()
        {
            var lists = _context.PersonalInfos;
            return Ok(lists);
        }
    }
}
