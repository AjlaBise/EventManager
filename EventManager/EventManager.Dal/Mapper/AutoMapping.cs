using AutoMapper;
using EventManager.Dal.Domain;
using EventManager.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Dal.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Event, EventDto>().ReverseMap();

            CreateMap<List<Event>, List<EventDto>>().ReverseMap();
        }

    }
}
