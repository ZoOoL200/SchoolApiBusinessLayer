using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiBusinessLayer.Features.General.Commands.AcademicCurriculumCommands;
using SchoolApiBusinessLayer.MappingProfiles.General.AcademicCurriculumMapers;
using SchoolApiDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicCurriculumHandler
{
    public class InsertCurriculumCommandHandler : IRequestHandler<InsertCurriculumCommand, GetCurriculumDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InsertCurriculumCommandHandler(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetCurriculumDto> Handle(InsertCurriculumCommand request, CancellationToken cancellationToken)
        {
            var curriculum = _mapper.Map<AcademicCurriculum>(request.curriculum);
            await _unitOfWork.AcademicCurriculum.AddAsync(curriculum);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<GetCurriculumDto>(curriculum);
        }
    }
}
