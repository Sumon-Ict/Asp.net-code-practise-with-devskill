using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Areas.Admin.Models;
using BO = TicketBookingSystem.Training.BusinessObjects;

namespace TicketBookingSystem.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomerModel, BO.Customer>().ReverseMap();

        }
    }
}
