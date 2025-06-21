using MediatR;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Commands.AcademicCurriculumCommands
{
    /// <summary>
    /// Command for deleting a curriculum by its ID.
    /// </summary>
    /// <param name="id">The Identifier of curriculum</param>
    public record DeleteCurriculumCommand(short id) : IRequest<GetCurriculumDto>
    {
    }
}
