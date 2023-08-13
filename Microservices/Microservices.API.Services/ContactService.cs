using Micriservices.API.Models;
using Microservicec.API.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.API.Services
{
    public class ContactService : IMicroservicesService
    {
        ContactDTO IMicroservicesService.GetContactById(int Id)
        {// veritabanı işlemleri burada yapılır
            return new ContactDTO {
                Id = Id,
                FirstName="Ali Kemal",
                LastName="SARI"
            };
        }
    }
}
