using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Originly_MVC5.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId;
        public List<int> GameIds { get; set; }

    }
}