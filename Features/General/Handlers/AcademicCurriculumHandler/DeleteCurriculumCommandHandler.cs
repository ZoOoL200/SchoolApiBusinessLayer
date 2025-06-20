using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiBusinessLayer.Features.General.Commands.AcademicCurriculumCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicCurriculumHandler
{
    public class DeleteCurriculumCommandHandler : IRequestHandler<DeleteCurriculumCommand, GetCurriculumDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteCurriculumCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetCurriculumDto> Handle(DeleteCurriculumCommand request, CancellationToken cancellationToken)
        {
            var curriculum = await _unitOfWork.AcademicCurriculum.GetByIdAsync(request.id);
            if (curriculum == null)
            {
                throw new KeyNotFoundException($"Curriculum with ID {request.id} not found.");
            }
            _unitOfWork.AcademicCurriculum.Delete(curriculum);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<GetCurriculumDto>(curriculum);
        }
    }
}
