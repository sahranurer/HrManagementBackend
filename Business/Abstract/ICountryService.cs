using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountryService
    {
        IDataResult<IList<Country>> GetAll();
        IDataResult<Country> GetById(string id);
        IDataResult<IList<Country>> GetCountriesByRegionId(int id);
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
    }
}
