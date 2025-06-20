using AutoMapper;
using MediatR;
using SchoolApiAccessLayer.UnitInterfaces;
using SchoolApiAccessLayer.UnitofWork;
using SchoolApiBusinessLayer.DTOs.Student;
using SchoolApiBusinessLayer.Features.Student.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApiBusinessLayer.Features.Student.Handlers
{
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, List<StudentDtos>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllStudentsQueryHandler( IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StudentDtos>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var Student = await _unitOfWork.Student.GetAllStudentsWithDetailsAsync();
            return _mapper.Map<List<StudentDtos>>(Student);
        }
    }
}
