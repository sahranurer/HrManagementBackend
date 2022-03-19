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
    public class LocationManager : ILocationService
    {
        readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IResult Add(Location location)
        {
            if (location is null)
            {
                return new ErrorResult();
            }
            _locationDal.Add(location);
            return new SuccessResult(LocationMessages.LocationAdded);
        }

        public IResult Delete(Location location)
        {
            _locationDal.Delete(location);
            return new SuccessResult(LocationMessages.LocationDeleted);
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll().ToList(), LocationMessages.LocationListed);
        }

        public IDataResult<Location> GetById(int id)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(x=>x.LocationId == id));
        }

        public IDataResult<IList<Location>> GetLocationsByCountryId(string id)
        {
            return new SuccessDataResult<IList<Location>>(_locationDal.GetAll(x => x.CountryId == id));
        }

        public IResult Update(Location location)
        {
            if (location is null)
            {
                return new ErrorResult();
            }
            _locationDal.Update(location);
            return new SuccessResult(LocationMessages.LocationUpdated);
        }
    }
}
