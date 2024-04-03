using Microsoft.AspNetCore.Mvc;
using myAplication.core.Modals;
using myAplication.core.serveis;
using myAplication.Server;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildServer _childServer;
        public ChildController(IChildServer childServer)
        {
            _childServer = childServer;
        }

        // GET: api/<ChildController>
        [HttpGet]
        public ActionResult<Child> Get()
        {
            return Ok(_childServer.GetAllCHldren());
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/<ChildController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
