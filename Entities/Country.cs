using Core.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Country :IEntity
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }
    }
}
