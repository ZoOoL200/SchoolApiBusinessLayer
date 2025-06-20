using MediatR;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Queries.AcademicCurriculumQueries
{
    public record GetAllCurriculumQuery : IRequest<List<GetCurriculumDto>>
    {
    }
}
