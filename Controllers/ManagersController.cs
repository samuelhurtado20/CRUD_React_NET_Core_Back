using CRUD_React_NET_Core_Back.Context;
using CRUD_React_NET_Core_Back.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_React_NET_Core_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ManagersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<ManagersController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var list = _context.Managers.ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<ManagersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var single = _context.Managers.FirstOrDefault(c => c.Id == id);
                return Ok(single);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<ManagersController>
        [HttpPost]
        public IActionResult Post([FromBody] Managers value)
        {
            try
            {
                var list = _context.Managers.Add(value);
                _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // PUT api/<ManagersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Managers value)
        {
            try
            {
                var list = _context.Managers.Update(value);
                _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE api/<ManagersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var element = _context.Managers.Find(id);
                if(element != null)
                {
                    _context.Managers.Remove(element);
                    _context.SaveChangesAsync();
                    return Ok();
                }

                return BadRequest("Invalid id");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
