using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<IList<Employee>> GetAll();
        IDataResult<Employee> GetById(int id);
        IDataResult<IList<Employee>> GetEmployeesByJobId(int id);
        IDataResult<IList<Employee>> GetEmployeesByDepartmentId(int id);
    }
}
