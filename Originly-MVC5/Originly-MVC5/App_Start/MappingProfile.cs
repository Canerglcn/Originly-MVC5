using AutoMapper;
using Originly_MVC5.Dtos;
using Originly_MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Originly_MVC5.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer,CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}