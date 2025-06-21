using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiBusinessLayer.DTOs.General.AcademicCurriculumDtos;
using SchoolApiBusinessLayer.DTOs.General.SchoolDtos;
using SchoolApiBusinessLayer.Features.General.Queries.AcademicCurriculumQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.General.Handlers.AcademicCurriculumHandler
{
    /// <summary>
    /// Handler for retrieving all curriculums along with their associated schools.
    /// </summary>
    public class GetAllCurriculumsWithSchoolQueryHandler : IRequestHandler<GetAllCurriculumWithSchoolQuery, ICollection<GetCurriculumWithSchoolsDtos>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllCurriculumsWithSchoolQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public  async Task<ICollection<GetCurriculumWithSchoolsDtos>> Handle(GetAllCurriculumWithSchoolQuery request, CancellationToken cancellationToken)
        {
            var curriculums = await _unitOfWork.AcademicCurriculum.GetAllAsync(c => c.Id);
            var result = new List<GetCurriculumWithSchoolsDtos>();

            foreach (var curriculum in curriculums)
            {
                var dto = _mapper.Map<GetCurriculumWithSchoolsDtos>(curriculum);
                var schools = await _unitOfWork.School.GetAllByCurriculumId(curriculum.Id);
                dto.Schools = _mapper.Map<List<GetSchoolDto>>(schools);
                result.Add(dto);
            }

            return result;
        }
    }
}
