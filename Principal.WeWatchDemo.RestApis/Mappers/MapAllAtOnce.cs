using AutoMapper;
using Principal.WeWatchDemo.DataAndModels.Models;
using Principal.WeWatchDemo.RestApis.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.WeWatchDemo.RestApis.Mappers
{
    public class MapAllAtOnce : Profile
    {
        public MapAllAtOnce()
        {
            //Poteš pánbúh.
            CreateMap<GridListModelDto, Evidences>()
                .ForMember(dest =>
                    dest.Id,
                    opt => opt.MapFrom(src => src.Id));
            CreateMap<GridListModelDto, Incidents>()
                .ForMember(dest =>
                    dest.Id,
                    opt => opt.MapFrom(src => src.Id));

            CreateMap<IncidentsDto, Incidents>();

            CreateMap<EvidencesDto, Evidences>();

            CreateMap<Reports, ReportsDto>();


        }
        
    }
}
