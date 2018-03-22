using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class LocationServices
    {
        public int LocationServicesId { get; set; }
        public int LocationId{ get; set; }
        public int SportsId { get; set; }
        public bool IsActive { get; set; }
    }
}
