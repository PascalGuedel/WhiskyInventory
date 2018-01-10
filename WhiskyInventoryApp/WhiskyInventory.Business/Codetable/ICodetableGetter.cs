using System.Collections.Generic;
using WhiskyInventory.Data.Models;

namespace WhiskyInventory.Business.Codetable
{
    public interface ICodetableGetter
    {
        IList<Region> GetRegions();
    }
}
