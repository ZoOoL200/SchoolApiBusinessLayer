using AutoMapper;
using SchoolApiBusinessLayer.DTOs.General.SchoolDtos;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.MappingProfiles.General.SchoolMapers
{
    /// <summary>
    /// Mapping profile for converting School entities to GetSchoolDto objects.
    /// </summary>
    public class GetSchoolProfile: Profile
    {
        public GetSchoolProfile()
        {
            // Create a mapping configuration from School entity to GetSchoolDto
            CreateMap<School,GetSchoolDto>();
        }
    }

}
