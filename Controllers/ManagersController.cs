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
        public ActionResult Get()
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
        public ActionResult Get(int id)
        {
            try
            {
                var single = _context.Managers.Where(c => c.Id == id);
                return Ok(single);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<ManagersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ManagersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ManagersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
