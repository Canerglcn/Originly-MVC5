using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Originly_MVC5.Dtos
{
    public class GenreDto
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}