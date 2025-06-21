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
    /// Profile for mapping InsertAcademicYearDto to AcadmicYear.
    /// </summary>
    public class InsertYearProfile : Profile
    {
        public InsertYearProfile()
        {
            // Mapping from AcadmicYear to InsertAcademicYearDto
            CreateMap<InsertAcademicYearDto , AcadmicYear>();
        }
    }

}
