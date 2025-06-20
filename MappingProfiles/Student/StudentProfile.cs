using AutoMapper;
using SchoolApiBusinessLayer.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.MappingProfiles.Student
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<SchoolApiDataLayer.Models.Student, StudentDtos.Get>()
                .ForMember(dest => dest.IdentityType, opt => opt.MapFrom(src => src.IdentityType.Title));
        }
    }
}
