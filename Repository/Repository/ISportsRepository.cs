using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Repository.Repository
{
    public interface ISportsRepository
    {
        List<Sports> GetAllAvailableSports();
        List<Location> GetLocationBySportsId(int sportsId);

    }
}
