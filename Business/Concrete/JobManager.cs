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
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

       

        public IResult Add(Job job)
        {
            if (job == null)
            {
                return new ErrorResult(Messages.JobNotAdded);
            }
            else
            {
                _jobDal.Add(job);
                return new SuccessResult(Messages.JobAdded);
            }
          
        }

        public IResult Delete(Job job)
        {
            _jobDal.Delete(job);
            return new SuccessResult(Messages.JobDeleted);
        }

        public IDataResult<IList<Job>> GetAll()
        {
            return new SuccessDataResult<IList<Job>>(_jobDal.GetAll(),Messages.JobListed);
        }

        public IDataResult<Job> GetById(int id)
        {
            return new SuccessDataResult<Job>(_jobDal.Get(x=>x.JobId == id));
        }

        public IResult Update(Job job)
        {
            _jobDal.Update(job);
            return new SuccessResult(Messages.JobUpdated);
        }
    }
}
