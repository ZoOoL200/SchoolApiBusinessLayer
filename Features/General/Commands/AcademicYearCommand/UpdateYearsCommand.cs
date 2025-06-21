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
    /// Command to update a list of academic years in the system.
    /// </summary>
    /// <param name="Years"></param>
    public record UpdateYearsCommand(ICollection<UpdateAcademicYearDto> Years) : IRequest<List<UpdateAcademicYearDto>>
    {
    }
}
