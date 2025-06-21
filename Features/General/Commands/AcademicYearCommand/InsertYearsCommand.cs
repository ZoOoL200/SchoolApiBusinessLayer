using MediatR;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Commands.AcademicYearCommand
{
    /// <summary>
    /// Command to insert a list of academic years into the system.
    /// </summary>
    /// <param name="Years"></param>
    public record InsertYearsCommand(ICollection<InsertAcademicYearDto> Years) : IRequest<List<GetAcademicYearDto>>
    {
    }
}
