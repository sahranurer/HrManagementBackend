using Business.Abstract;
using Business.Constans;
using Core.Utilities.Abstract;
using Core.Utilities.Results.Success;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<IList<Employee>> GetAll()
        {
            return new SuccessDataResult<IList<Employee>>(_employeeDal.GetAll().ToList(),EmployeeMessages.EmployeeListed);
        }

        public IDataResult<Employee> GetById(int id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(x => x.EmployeeId == id));
        }

        

        public IDataResult<IList<Employee>> GetEmployeesByDepartmentId(int id)
        {
            return new SuccessDataResult<IList<Employee>>(_employeeDal.GetAll(x => x.DepartmentId == id));
        }

        public IDataResult<IList<Employee>> GetEmployeesByJobId(int id)
        {
            return new SuccessDataResult<IList<Employee>>(_employeeDal.GetAll(x=>x.JobId == id));
        }
    }
}
