using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApiDataLayer.Models;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;

namespace SchoolApiBusinessLayer.MappingProfiles.General.AcademicYearMapers
{
    /// <summary>
    /// Profile for mapping AcadmicYear to GetAcademicYearDto.
    /// </summary>
    public class GetYearProfile : Profile
    {
        public GetYearProfile()
        {
            // Mapping from AcadmicYear to GetAcademicYearDto
            CreateMap<AcadmicYear, GetAcademicYearDto>();
        }
    }
}
