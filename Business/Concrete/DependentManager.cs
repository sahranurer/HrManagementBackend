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
    public class DependentManager : IDependentService
    {
        IDependentDal _dependentDal;

        public DependentManager(IDependentDal dependentDal)
        {
            _dependentDal = dependentDal;
        }

        public IDataResult<IList<Dependent>> GetAll()
        {
            return new SuccessDataResult<IList<Dependent>>(_dependentDal.GetAll().ToList(), DependentMessages.DependentListed);
        }

        public IDataResult<Dependent> GetById(int id)
        {
            return new SuccessDataResult<Dependent>(_dependentDal.Get(x=>x.DependentId == id));
        }

        public IDataResult<IList<Dependent>> GetDependentByEmployeeId(int id)
        {
            return new SuccessDataResult<IList<Dependent>>(_dependentDal.GetAll(x => x.EmployeeId == id),DependentMessages.DependentListed);
        }
    }
}
