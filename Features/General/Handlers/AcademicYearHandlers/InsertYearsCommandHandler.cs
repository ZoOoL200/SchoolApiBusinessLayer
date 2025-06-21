using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;
using SchoolApiBusinessLayer.Features.General.Commands.AcademicYearCommand;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicYearHandlers
{
    /// <summary>
    /// Handles the command to insert a collection of academic years into the system.
    /// </summary>
    public class InsertYearsCommandHandler : IRequestHandler<InsertYearsCommand, List<GetAcademicYearDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InsertYearsCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetAcademicYearDto>> Handle(InsertYearsCommand request, CancellationToken cancellationToken)
        {
            var years = _mapper.Map<ICollection<AcadmicYear>>(request.Years);
            foreach (var year in years)
            {
                var parts = year.YearTitle.Split('-');
                if (parts.Length != 2 || !int.TryParse(parts[0], out var startYear) || !int.TryParse(parts[1], out var endYear))
                {
                    throw new ArgumentException("YearTitle must be in format 'YYYY-YYYY' with valid numbers.");
                }

                if (endYear != startYear + 1)
                {
                    throw new ArgumentException("The end year must be greater than the start year by one.");
                }

            }
            await _unitOfWork.AcademicYear.AddAsync(years);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<List<GetAcademicYearDto>>(years);
        }
    }
}
