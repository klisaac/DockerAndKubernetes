
using System.Collections.Generic;
using System.Threading.Tasks;
using Microservice.Api1.Core.Repository.Base;
using Microservice.Api1.Core.Models.Entities;
using Microservice.Api1.Core.Specifications.Base;

namespace Microservice.Api1.Core.Repository
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<IEnumerable<Employee>> SearchEmployeesAsync(ISpecification<Employee> specification);
    }
}
