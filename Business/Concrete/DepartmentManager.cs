using Business.Abstract;
using Business.Constans;
using Core.Utilities.Abstract;
using Core.Utilities.Results.Error;
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
    public class DepartmentManager : IDepartmentService
    {

        IDepartmentDal _departmantDal;

        public DepartmentManager(IDepartmentDal departmantDal)
        {
            _departmantDal = departmantDal;
        }

        public IResult Add(Department department)
        {
            if (department is null)
            {
                return new ErrorResult();
            }
            _departmantDal.Add(department);
            return new SuccessResult(DepartmentMessages.DepartmentAdded);
        }

        public IResult Delete(Department department)
        {
            _departmantDal.Delete(department);
            return new SuccessResult(DepartmentMessages.DepartmentDeleted);
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_departmantDal.GetAll().ToList(),DepartmentMessages.DepartmentListed);
        }

        public IDataResult<Department> GetById(int id)
        {
            return new SuccessDataResult<Department>(_departmantDal.Get(x => x.DepartmentId == id));
        }

        public IDataResult<IList<Department>> GetDepartmentaByLocationId(int id)
        {
            return new SuccessDataResult<IList<Department>>(_departmantDal.GetAll(x => x.LocationId == id));
        }

        public IResult Update(Department department)
        {
            if (department is null)
            {
                return new ErrorResult();
            }
            _departmantDal.Update(department);
            return new SuccessResult(DepartmentMessages.DepartmentUpdated);
        }
    }
}
