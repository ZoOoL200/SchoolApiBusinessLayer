using MediatR;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Queries.AcademicCurriculumQueries
{
    /// <summary>
    /// Query to retrieve all academic curriculums along with their associated schools.
    /// </summary>
    public record GetAllCurriculumWithSchoolQuery : IRequest<ICollection<GetCurriculumWithSchoolsDtos>>
    {
    }
}
