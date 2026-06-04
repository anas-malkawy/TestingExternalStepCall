using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        public IActionResult Get()
        {
            var res = new List<object>
    {
        new
        {
            documentId = 101,
            fileName = "id.pdf",
            documentType = "ID",
            email="anas.jawabreh@aisdigicore.com"
        },
        new
        {
            documentId = 102,
            fileName = "salary.pdf",
            documentType = "SalaryCertificate",
            email="anas.malkawy1999@gmail.com"
        },
        new
        {
            documentId = 103,
            fileName = "contract.pdf",
            documentType = "Contract",
            email="anas.jawabreh@aisdigicore.com"
        }
    };

            return Ok(res);
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
