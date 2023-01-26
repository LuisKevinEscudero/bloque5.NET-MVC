using AutoMapper;
using prueba.DTOs;
using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
        }
    }
}