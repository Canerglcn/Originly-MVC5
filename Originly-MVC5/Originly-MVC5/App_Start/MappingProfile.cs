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
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Game, GameDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();


            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
             Mapper.CreateMap<GameDto, Game>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}