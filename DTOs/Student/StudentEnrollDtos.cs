using SchoolApiAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.DTOs.Student
{
    public class StudentEnrollDtos 
    {
        public class Get
        {
            public long EnrollmentId { get; set; }
            public required string StudentName { get; set; }
            public required string Gender { get; set; }
            public required string ClassRoomName { get; set; }
            public DateTime EnrollmentDate { get; set; }
            public required string Status { get; set; }
            public bool Active { get; set; }
        }

       
    }
}
