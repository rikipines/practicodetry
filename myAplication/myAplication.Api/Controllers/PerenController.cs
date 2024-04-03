using Microsoft.AspNetCore.Mvc;
using myAplication.core.Modals;
using myAplication.core.serveis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerenController : ControllerBase
    {

        private readonly IMParentServer _parentServer;
        public PerenController(IMParentServer parentServer)
        {
           
            _parentServer = parentServer;
        }

        // GET: api/<PerenController>
        [HttpGet]
        public ActionResult<Parent> Get()
        {
            return Ok(_parentServer.GetAllParent());
        }

        // GET api/<PerenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PerenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PerenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PerenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
