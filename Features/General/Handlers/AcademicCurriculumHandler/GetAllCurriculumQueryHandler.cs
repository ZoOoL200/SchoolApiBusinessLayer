using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiAccessLayer.UnitofWork;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiBusinessLayer.Features.General.Commands.AcademicCurriculumCommands;
using SchoolApiBusinessLayer.Features.General.Queries.AcademicCurriculumQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicCurriculumHandler
{
    public class GetAllCurriculumQueryHandler : IRequestHandler<GetAllCurriculumQuery, List<GetCurriculumDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllCurriculumQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetCurriculumDto>> Handle(GetAllCurriculumQuery request, CancellationToken cancellationToken)
        {
            var curriculums = await _unitOfWork.AcademicCurriculum.GetAllAsync();
            return _mapper.Map<List<GetCurriculumDto>>(curriculums);
        }
    }
}
