using MediatR;
using Microservice.Api1.Application.Responses;

namespace Microservice.Api1.Application.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeResponse>
    {
        public int EmployeeId { get; }
        public  GetEmployeeByIdQuery(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}
