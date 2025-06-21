using SchoolApiBusinessLayer.DTOs.General.SchoolDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos
{
    /// <summary>
    /// Data Transfer Object for retrieving curriculum information along with associated schools.
    /// </summary>
    public class GetCurriculumWithSchoolsDtos
    {
        public short Id { get; set; }
        public required string CurriculumTitle { get; set; }

        public ICollection<GetSchoolDto>? Schools { get; set; }
    }
}
