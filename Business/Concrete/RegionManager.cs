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
    public class RegionManager : IRegionService
    {

        IRegionDal _regionDal;

        public RegionManager(IRegionDal regionDal)
        {
            _regionDal = regionDal;
        }

        public IResult Add(Region region)
        {
            if (region is null)
            {
                return new ErrorResult(RegionMessages.RegionNotAdded);
            }
            else
            {
                _regionDal.Add(region);
                return new SuccessResult(RegionMessages.RegionAdded);
            }

        }

        public IResult Delete(Region region)
        {
            _regionDal.Delete(region);
            return new SuccessResult(RegionMessages.RegionDeleted);
            
        }

        public IDataResult<List<Region>> GetAll()
        {
            return new SuccessDataResult<List<Region>>(_regionDal.GetAll().ToList(), RegionMessages.RegionListed);
        }

        public IDataResult<Region> GetById(int id)
        {
            return new SuccessDataResult<Region>(_regionDal.Get(x => x.RegionId == id));
        }

        public IResult Update(Region region)
        {
            if (region is null)
            {
                return new ErrorResult();
            }
            else
            {
                _regionDal.Update(region);
                return new SuccessResult(RegionMessages.RegionUpdated);
            }
        }
    }
}
