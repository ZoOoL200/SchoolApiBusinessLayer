using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;
using SchoolApiBusinessLayer.Features.General.Queries.AcademucYearQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicYearHandlers
{
    /// <summary>
    /// Handler for retrieving all academic years.
    /// </summary>
    public class GetAllYearsQueryHandler : IRequestHandler<GetAllYearsQuery, List<GetAcademicYearDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllYearsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetAcademicYearDto>> Handle(GetAllYearsQuery request, CancellationToken cancellationToken)
        {
            var academicYears = await _unitOfWork.AcademicYear.GetAllAsync(y=> y.Id);
            return _mapper.Map<List<GetAcademicYearDto>>(academicYears);
        }
    }
}
