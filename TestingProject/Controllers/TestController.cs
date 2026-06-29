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
            Newemail="anas.jawabreh@aisdigicore.com"
        },
        new
        {
            documentId = 102,
            fileName = "salary.pdf",
            documentType = "SalaryCertificate",
            Newemail="anas.malkawy1999@gmail.com"
        }
    };

            return Ok(res);
        }
        // GET: api/<TestController>
        [HttpGet("test")]
        public IActionResult Geta()
        {
            var res = "{\r\n  \"data\": {\r\n    \"users\": [\r\n      {\r\n        \"id\": 1,\r\n        \"profile\": {\r\n          \"email\": \"anas@gmail.com\",\r\n          \"roles\": [\"Admin\", \"Developer\"]\r\n        },\r\n        \"accounts\": [\r\n          {\r\n            \"accountId\": 111,\r\n            \"transactions\": [\r\n              { \"trxId\": 1, \"amount\": 500 },\r\n              { \"trxId\": 2, \"amount\": 200 }\r\n            ]\r\n          }\r\n        ]\r\n      },\r\n      {\r\n        \"id\": 2,\r\n        \"profile\": {\r\n          \"email\": \"ali@gmail.com\",\r\n          \"roles\": [\"Tester\", \"Support\"]\r\n        }\r\n      }\r\n    ]\r\n  }\r\n}";

            return Ok(res);
        }

        // GET: api/<TestController>
        [HttpGet("a")]
        public IActionResult Gett()
        {
            var res = new List<object>
    {
        new
        {
            documentId = 101,
            fileName = "id.pdf",
            documentType = "ID",
            Newemail="anas.jawabreh@aisdigicore.com"
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
