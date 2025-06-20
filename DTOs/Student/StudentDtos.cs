using SchoolApiAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.Student
{
    public class StudentDtos 
    {
        public class Get
        {
            public long Id { get; set; }
            public required string StudentName { get; set; }
            public required string Gender { get; set; }
            public required string IdentityType { get; set; }
            public required string IdentityNumber { get; set; }
            public string? Address { get; set; }
            public DateOnly? BirthDate { get; set; }
            public string? MedicalHistory { get; set; }
            public string? Note { get; set; }
            public byte[]? Image { get; set; }
        }
        
    }


}
