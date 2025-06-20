using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos
{
    /// <summary>
    /// Data Transfer Object for retrieving curriculum information.
    /// </summary>
    public class GetCurriculumDto
    {
        public short Id { get; set; }
        public required string CurriculumTitle { get; set; }
    }
}
