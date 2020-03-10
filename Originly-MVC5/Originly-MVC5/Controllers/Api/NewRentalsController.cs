using Originly_MVC5.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Originly_MVC5.Controllers.Api
{
    public class NewRentalsController : ApiController
    {  

       [HttpPost]
       public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            throw new Exception();
        }
    }
}
