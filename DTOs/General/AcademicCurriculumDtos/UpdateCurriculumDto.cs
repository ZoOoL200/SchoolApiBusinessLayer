using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos
{
    /// <summary>
    /// Data Transfer Object for updating an academic curriculum.
    /// </summary>
    public class UpdateCurriculumDto
    {
        [Required(ErrorMessage ="The Id is Required")]
        public short Id { get; set; }

        [Required(ErrorMessage = "The Academic Name Cann't be Empty.")]
        [MaxLength(25, ErrorMessage = "The Academic Name must not more than 25 char.")]
        public required string CurriculumTitle { get; set; }
    }
}
