using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;
            if (_context.todoItems.Count() == 0)
            {
            }

            {
                _context.todoItems.Add(new TodoItem {Name = "Item1"});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<TodoItem> GetAll()
        {
            return _context.todoItems.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            var item = _context.todoItems.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null) return BadRequest();
            _context.todoItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetTodo", new {id = item.Id}, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TodoItem item)
        {
            if (item == null || item.Id != id) return BadRequest();
            var todo = _context.todoItems.Find(id);
            if (todo == null) return NotFound();
            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _context.todoItems.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            var todo = _context.todoItems.Find(id);
            if (todo == null) return NotFound();
            _context.todoItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}