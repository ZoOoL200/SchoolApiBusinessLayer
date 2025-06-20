using AutoMapper;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.MappingProfiles.General.AcademicCurriculumMapers
{
    public class GetCurriculumProfile : Profile
    {
        public GetCurriculumProfile()
        {
            CreateMap<AcademicCurriculum, GetCurriculumDto>();
        }
       
    }
}
