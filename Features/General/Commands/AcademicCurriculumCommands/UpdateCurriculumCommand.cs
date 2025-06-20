using MediatR;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Commands.AcademicCurriculumCommands
{
    public record UpdateCurriculumCommand(UpdateCurriculumDto curriculum) : IRequest<UpdateCurriculumDto>
    {
    }
}
