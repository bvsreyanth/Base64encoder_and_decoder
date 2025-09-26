using DependencyInj.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IPersonService _personService1;

        public PersonController(IPersonService personService,IPersonService personService1)
        {
           _personService = personService;
            _personService1 = personService1;   
        }

        [HttpGet]
        public ActionResult<string> GetFirstPersonId()
        {
            Guid uniqueId = _personService.GenerateGuid();
            Guid uniqueId1 = _personService1.GenerateGuid();
            var response = new { UniqueId = uniqueId.ToString(), UniqueId1 = uniqueId1.ToString() };
            return Ok(response);
        }

    }
}