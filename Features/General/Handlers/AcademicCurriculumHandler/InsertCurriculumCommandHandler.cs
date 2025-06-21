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
    /// <summary>
    /// Handler for inserting a range of academic curriculums into the system.
    /// </summary>
    public class InsertCurriculumCommandHandler : IRequestHandler<InsertCurriculumCommand, List<GetCurriculumDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InsertCurriculumCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetCurriculumDto>> Handle(InsertCurriculumCommand request, CancellationToken cancellationToken)
        {
            var curriculums = _mapper.Map<List<AcademicCurriculum>>(request.curriculums);
            await _unitOfWork.AcademicCurriculum.AddAsync(curriculums);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<List<GetCurriculumDto>>(curriculums);
        }
    }
}
