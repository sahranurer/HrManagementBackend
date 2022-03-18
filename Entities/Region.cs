using Core.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Region :IEntity
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
    }
}
