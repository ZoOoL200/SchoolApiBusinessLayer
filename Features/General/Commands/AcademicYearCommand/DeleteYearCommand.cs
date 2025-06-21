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
    /// Command for deleting an academic year by its ID.
    /// </summary>
    /// <param name="id"></param>
    public record DeleteYearCommand(short id) : IRequest<GetAcademicYearDto>
    {
    }
}
