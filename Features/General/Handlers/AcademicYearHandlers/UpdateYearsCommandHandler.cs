using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicYearDtos;
using SchoolApiBusinessLayer.Features.General.Commands.AcademicYearCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicYearHandlers
{
    /// <summary>
    /// Handles the command to update a collection of academic years in the system.
    /// </summary>
    public class UpdateYearsCommandHandler : IRequestHandler<UpdateYearsCommand, List<UpdateAcademicYearDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateYearsCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<UpdateAcademicYearDto>> Handle(UpdateYearsCommand request, CancellationToken cancellationToken)
        {
            var Years = new List<UpdateAcademicYearDto>();
            foreach (var item in request.Years)
            {
                var year = _unitOfWork.AcademicYear.GetByIdAsync(item.Id).Result;
                if (year == null)
                {
                    throw new KeyNotFoundException($"Academic Year with ID {item.Id} not found.");
                }
                var parts = item.YearTitle.Split('-');
                if (parts.Length != 2 || !int.TryParse(parts[0], out var startYear) || !int.TryParse(parts[1], out var endYear))
                {
                    throw new ArgumentException("YearTitle must be in format 'YYYY-YYYY' with valid numbers.");
                }
                if (endYear != startYear + 1)
                {
                    throw new ArgumentException("The end year must be greater than the start year by one.");
                }
                _mapper.Map(item, year);
                Years.Add(_mapper.Map<UpdateAcademicYearDto>(year));
            }
            await _unitOfWork.CompleteAsync();
            return Years.OrderBy(x => x.Id).ToList();
           
        }
    }
}
