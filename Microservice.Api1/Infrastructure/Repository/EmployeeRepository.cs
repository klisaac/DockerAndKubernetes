using System.Collections.Generic;
using System.Threading.Tasks;
using Microservice.Api1.Core.Models.Entities;
using Microservice.Api1.Infrastructure.Data;
using Microservice.Api1.Core.Repository;
using Microservice.Api1.Core.Specifications.Base;
using Microservice.Api1.Infrastructure.Repository.Base;

namespace Microservice.Api1.Infrastructure.Repository
{ 
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(Api1Context dataContext)
            : base(dataContext) {}

        public async Task<IEnumerable<Employee>> SearchEmployeesAsync(ISpecification<Employee> specification)
        {
            return await GetAsync(specification);
        }
    }
}