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
        public ContactDTO GetAllUsers()
        {
            return new ContactDTO
            {
                Id = 1,
                FirstName = "Ali Kemal",
                LastName = "SARI"

            };
        }

        ContactDTO IMicroservicesService.GetContactById(int Id)
        {// veritabanı işlemleri burada yapılır

         
            if (Id == 1)
            {
                return new ContactDTO
                {
                    Id = Id,
                    FirstName = "Ali Kemal",
                    LastName = "SARI"

                };
            }
            else if (Id == 2)
            {
                return new ContactDTO
                {
                    Id = Id,
                    FirstName = "2 Numaralı Kullanıcı",
                    LastName = "SAYisim"
                };
            }
            else
                return  null;
                
        }
        }
    }

