using Microsoft.AspNetCore.Mvc;
using myAplication.core.Modals;
using myAplication.core.serveis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAplication.Api.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class Maneger4Controller : ControllerBase
    {



        private readonly IManegerServies _IManegerServies;
        public Maneger4Controller(IManegerServies iManegerServies)
        {
            _IManegerServies = iManegerServies;
        }

        // GET: api/<Maneger4Controller>
        [HttpGet]
        public IEnumerable<maneger> Get()
        {
            return _IManegerServies.GetAllManeger();
        }

        // GET api/<Maneger4Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Maneger4Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Maneger4Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Maneger4Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
