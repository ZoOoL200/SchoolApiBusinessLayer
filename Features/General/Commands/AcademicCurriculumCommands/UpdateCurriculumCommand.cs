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
    /// Command to update an existing curriculum in the system.
    /// </summary>
    /// <param name="curriculum">entity object <see cref="UpdateCurriculumDto"/></param>
    public record UpdateCurriculumCommand(ICollection<UpdateCurriculumDto> curriculums) : IRequest<List<UpdateCurriculumDto>>
    {
    }
}
