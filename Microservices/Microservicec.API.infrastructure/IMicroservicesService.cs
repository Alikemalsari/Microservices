using Micriservices.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservicec.API.infrastructure
{
    public interface IMicroservicesService
    {
        public ContactDTO GetContactById(int Id);
    }
}
