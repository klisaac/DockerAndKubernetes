using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using Microservice.Api1.Application.Queries;
using Microservice.Api1.Core.Repository;
using Microservice.Api1.Core.Specifications;
using Microservice.Api1.Application.Responses;

namespace Microservice.Api1.Application.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<EmployeeResponse> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<EmployeeResponse>(await _employeeRepository.GetSingleAsync(new EmployeeSpecification(request.EmployeeId)));
        }
    }
}
