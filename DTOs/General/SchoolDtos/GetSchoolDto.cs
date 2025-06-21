using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.General.SchoolDtos
{
    /// <summary>
    /// Data Transfer Object for retrieving school information.
    /// </summary>
    public class GetSchoolDto
    {
        [Required]
        public short Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="The School Name must not be more than 50 char")]
        public required string SchoolTitle { get; set; }
    }
}
