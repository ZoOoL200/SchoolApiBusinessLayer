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
    /// Profile for mapping AcademicCurriculum to GetCurriculumWithSchoolsDtos.
    /// </summary>
    public class GetCurriculumWithSchoolProfile :Profile
    {
        public GetCurriculumWithSchoolProfile()
        {
            // Mapping from AcademicCurriculum to GetCurriculumWithSchoolsDtos
            CreateMap<AcademicCurriculum, GetCurriculumWithSchoolsDtos>();
        }
    }
}
