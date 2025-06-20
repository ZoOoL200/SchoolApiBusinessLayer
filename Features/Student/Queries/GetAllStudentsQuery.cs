using MediatR;
using SchoolApiBusinessLayer.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.Student.Queries
{
    public record GetAllStudentsQuery : IRequest<List<StudentDtos>>
    {
    }
}
