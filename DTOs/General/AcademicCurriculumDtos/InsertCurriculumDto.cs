using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos
{
    /// <summary>
    /// Data Transfer Object for inserting a new curriculum.
    /// </summary>
    public class InsertCurriculumDto
    {
        [Required(ErrorMessage ="The Academic Name Cann't be Empty.")]
        [MaxLength(25, ErrorMessage ="The Academic Name must not more than 25 char.")]
        public required string CurriculumTitle { get; set; }
    }
}
