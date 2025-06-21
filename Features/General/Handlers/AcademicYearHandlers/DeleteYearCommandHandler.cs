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
    /// Handler for deleting an academic year.
    /// </summary>
    public class DeleteYearCommandHandler : IRequestHandler<DeleteYearCommand, GetAcademicYearDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteYearCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetAcademicYearDto> Handle(DeleteYearCommand request, CancellationToken cancellationToken)
        {
            var year = await _unitOfWork.AcademicYear.GetByIdAsync(request.id);
            if (year == null)
            {
                throw new KeyNotFoundException($"Academic Year with ID {request.id} not found.");
            }
            _unitOfWork.AcademicYear.Delete(year);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<GetAcademicYearDto>(year);
        }
    }
}
