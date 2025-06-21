using AutoMapper;
using Microsoft.Data.SqlClient;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.MappingProfiles.General.AcademicCurriculumMapers
{
    /// <summary>
    /// Mapping profile for converting AcademicCurriculum entities to GetCurriculumDto objects.
    /// </summary>
    public class GetCurriculumProfile : Profile
    {
        public GetCurriculumProfile()
        {
            // Create a mapping from AcademicCurriculum to GetCurriculumDto
            CreateMap<AcademicCurriculum, GetCurriculumDto>();
        }
       
    }
}
