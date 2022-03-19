using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDependentService
    {
        IDataResult<IList<Dependent>> GetAll();
        IDataResult<Dependent> GetById(int id);
        IDataResult<IList<Dependent>> GetDependentByEmployeeId(int id);
    }
}
