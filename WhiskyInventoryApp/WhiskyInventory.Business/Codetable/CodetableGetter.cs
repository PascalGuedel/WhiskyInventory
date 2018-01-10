using System.Collections.Generic;
using System.Linq;
using WhiskyInventory.Data.Models;

namespace WhiskyInventory.Business.Codetable
{
    public class CodetableGetter : ICodetableGetter
    {
        private readonly WhiskyStoreContext _context;

        public CodetableGetter(WhiskyStoreContext context)
        {
            _context = context;
        }

        public IList<Region> GetRegions()
        {
            return _context.Region.ToList();
        }
    }
}
