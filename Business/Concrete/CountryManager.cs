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
    public class CountryManager : ICountryService

    {

        readonly ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country country)
        {
            if (country is null)
            {
                return new ErrorResult(CountryMessages.CountryNotAdded);
            }
            else
            {
                _countryDal.Add(country);
                return new SuccessResult(CountryMessages.CountryAdded);
            }
        }

        public IResult Delete(Country country)
        {
            _countryDal.Delete(country);
            return new SuccessResult(CountryMessages.CountryDeleted);
        }

        public IDataResult<IList<Country>> GetAll()
        {
            return new SuccessDataResult<IList<Country>>(_countryDal.GetAll().ToList(), CountryMessages.CountryListed);
        }

        public IDataResult<Country> GetById(string id)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(x=>x.CountryId == id));
        }

        public IDataResult<IList<Country>> GetCountriesByRegionId(int id)
        {
            return new SuccessDataResult<IList<Country>>(_countryDal.GetAll(x => x.RegionId == id));
        }

        public IResult Update(Country country)
        {
            if (country is null)
            {
                return new ErrorResult();
            }
            else
            {
                _countryDal.Update(country);
                return new SuccessResult(CountryMessages.CountryUpdated);
            }
        }
    }
}
