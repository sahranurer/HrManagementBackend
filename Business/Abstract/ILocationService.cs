using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IDataResult<List<Location>> GetAll();
        IDataResult<Location> GetById(int id);
        IDataResult<IList<Location>> GetLocationsByCountryId(string id);
        IResult Add(Location location);
        IResult Delete(Location location);
        IResult Update(Location location);
    }
}
