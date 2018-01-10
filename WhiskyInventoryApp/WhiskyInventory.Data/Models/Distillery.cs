using System;
using System.Collections.Generic;

namespace WhiskyInventory.Data.Models
{
    public partial class Distillery
    {
        public Distillery()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public int RegionId { get; set; }

        public Region Region { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
    }
}
