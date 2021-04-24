using System.Collections.Generic;
using MediatR;
using Microservice.Api1.Application.Responses;

namespace Microservice.Api1.Application.Queries
{
    public class GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeResponse>>
    {
        public GetAllEmployeesQuery()
        {
        }
    }
}
