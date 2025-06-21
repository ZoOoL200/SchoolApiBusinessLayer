using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos
{
    /// <summary>
    /// Data Transfer Object for retrieving academic year information.
    /// </summary>
    public class GetAcademicYearDto
    {

        public short Id { get; set; }

        public required string YearTitle { get; set; }

    }
}
