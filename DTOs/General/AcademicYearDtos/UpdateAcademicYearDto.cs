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
    /// Data Transfer Object for updating an existing academic year.
    /// </summary>
    public class UpdateAcademicYearDto
    {
        [Required(ErrorMessage = "The Id is Required")]
        public short Id { get; set; }

        [Required(ErrorMessage = "The Year Title cannot be empty.")]
        [MaxLength(20, ErrorMessage = "The Year Title must not exceed 20 characters.")]
        [RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage = "The Year Title must contain exactly the year of the date one Hyphen (-) and the next year. Example(2000-2001)")]
        /// <example>2000-2001</example>
        public required string YearTitle { get; set; }
    }
}
