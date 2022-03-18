using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobService
    {
        IDataResult<IList<Job>> GetAll();
        IDataResult<Job> GetById(int id);
        IResult Add(Job job);
        IResult Update(Job job);
        IResult Delete(Job job);
    }
}
