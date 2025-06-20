using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiBusinessLayer.Features.General.Commands.AcademicCurriculumCommands;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicCurriculumHandler
{
    public class UpdateCurriculumCommandHanlder : IRequestHandler<UpdateCurriculumCommand, UpdateCurriculumDto>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateCurriculumCommandHanlder(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UpdateCurriculumDto> Handle(UpdateCurriculumCommand request, CancellationToken cancellationToken)
        {
            var curriculum = await _unitOfWork.AcademicCurriculum.GetByIdAsync(request.curriculum.Id);
            if (curriculum == null)
            {
                throw new KeyNotFoundException($"Curriculum with ID {request.curriculum.Id} not found.");
            }
            _mapper.Map(request.curriculum,curriculum);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<UpdateCurriculumDto>(curriculum);

        }
    }
}
