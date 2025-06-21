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
    /// <summary>
    /// Handler for updating an academic curriculum.
    /// </summary>
    public class UpdateCurriculumCommandHanlder : IRequestHandler<UpdateCurriculumCommand, List<UpdateCurriculumDto>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateCurriculumCommandHanlder(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<UpdateCurriculumDto>> Handle(UpdateCurriculumCommand request, CancellationToken cancellationToken)
        {
            var curriculums = new List<UpdateCurriculumDto>();
            foreach (var item in request.curriculums)
            {
                var curriculum = await _unitOfWork.AcademicCurriculum.GetByIdAsync(item.Id);
                if (curriculum == null)
                {
                    throw new KeyNotFoundException($"Acdemic Year with ID {item.Id} not found.");
                    
                }
                _mapper.Map(item, curriculum);
                curriculums.Add(_mapper.Map<UpdateCurriculumDto>(curriculum));
            }
            await _unitOfWork.CompleteAsync();
            return curriculums.OrderBy(x=> x.Id).ToList();

        }
    }
}
