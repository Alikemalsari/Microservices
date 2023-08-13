using Micriservices.API.Models;
using Microservicec.API.infrastructure;
using Microservices.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMicroservicesService contactService;

        public ValuesController(IMicroservicesService ContactService) 
        {
           contactService = ContactService;
        }

        [HttpGet("{Id}")]
        public ContactDTO Get(int Id)
        {
          return contactService.GetContactById(Id);
        }
    }
}
