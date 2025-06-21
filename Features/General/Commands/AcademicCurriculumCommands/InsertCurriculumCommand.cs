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
    /// Command for inserting a range academic curriculum into the system.
    /// </summary>
    /// <param name="curriculum">collection of entity objects <see cref="InsertCurriculumDto"/></param>
    public record InsertCurriculumCommand(ICollection<InsertCurriculumDto> curriculums) : IRequest<List<GetCurriculumDto>>
    {
    }
}
