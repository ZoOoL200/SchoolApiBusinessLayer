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
    /// <summary>
    /// Profile for mapping between UpdateCurriculumDto and AcademicCurriculum.
    /// </summary>
    public class UpdateCurriculumProfile : Profile
    {
        public UpdateCurriculumProfile()
        {
            // Mapping from UpdateCurriculumDto to AcademicCurriculum
            CreateMap<UpdateCurriculumDto, AcademicCurriculum>();

            // Mapping from AcademicCurriculum to UpdateCurriculumDto
            CreateMap<AcademicCurriculum, UpdateCurriculumDto>();
        }
    }
}
