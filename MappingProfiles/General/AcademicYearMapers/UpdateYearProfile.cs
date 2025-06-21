using AutoMapper;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.MappingProfiles.General.AcademicYearMapers
{
    /// <summary>
    /// Profile for mapping UpdateAcademicYearDto to AcadmicYear.
    /// </summary>
    public class UpdateYearProfile : Profile
    {
        public UpdateYearProfile()
        {
            // Mapping from AcadmicYear to UpdateAcademicYearDto
            CreateMap<UpdateAcademicYearDto, AcadmicYear>();

            // Mapping from AcadmicYear to UpdateAcademicYearDto
            CreateMap<AcadmicYear, UpdateAcademicYearDto>();
        }
    }

}
