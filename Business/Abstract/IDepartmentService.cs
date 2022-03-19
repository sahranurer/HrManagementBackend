using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<List<Department>> GetAll();
        IDataResult<Department> GetById(int id);
        IDataResult<IList<Department>> GetDepartmentaByLocationId(int id);
        IResult Add(Department department);
        IResult Delete(Department department);
        IResult Update(Department department);
    }
}
