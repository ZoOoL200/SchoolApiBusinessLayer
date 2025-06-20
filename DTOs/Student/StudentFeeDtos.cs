using SchoolApiAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.Student
{
    /// <summary>
    /// Represents a Data Transfer Object (DTO) for viewing student fee details.
    /// </summary>
    public class StudentFeeDtos 
    {
        public class Get
        {
            public long EnrollId { get; set; }
            public required string StudentName { get; set; }
            public required string ClassRoomName { get; set; }
            public required string Gender { get; set; }
            public decimal TuitionFee { get; set; }
            public decimal TuitionFeePaid { get; set; }
            public decimal TutionRemaining { get; set; }
            public decimal RegistrationFee { get; set; }
            public decimal RegistrationFeePaid { get; set; }
            public decimal RegistrationFeeRemaining { get; set; }
            public bool Active { get; set; }
            public string? Note { get; set; }
        }
       
    }
}
