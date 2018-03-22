using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Repository.Context;

namespace Repository.Repository
{
    public class SportsRepository:ISportsRepository
    {
        public readonly PlayHardDbContext _DbContext;
        public SportsRepository(PlayHardDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public List<Sports> GetAllAvailableSports()
        {
            return _DbContext.Sports.Where(e => e.IsActive).ToList();
        }

        public List<Location> GetLocationBySportsId(int sportsId)
        {
            var locationIds= _DbContext.LocationServices.Where(ls => ls.SportsId == sportsId && ls.IsActive).Select(ls=>ls.LocationId).ToList();
            return _DbContext.Location.Where(l => locationIds.Contains(l.LocationId) && l.IsActive).ToList();
        }
    }
}
