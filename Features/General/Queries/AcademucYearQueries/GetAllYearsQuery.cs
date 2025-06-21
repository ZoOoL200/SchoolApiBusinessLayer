using MediatR;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Queries.AcademucYearQueries
{
    /// <summary>
    /// Query to retrieve all academic years.
    /// </summary>
    public record GetAllYearsQuery : IRequest<List<GetAcademicYearDto>>
    {
    }
}
