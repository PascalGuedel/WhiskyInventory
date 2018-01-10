using System;
using System.Collections.Generic;

namespace WhiskyInventory.Data.Models
{
    public partial class Region
    {
        public Region()
        {
            Distillery = new HashSet<Distillery>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        public ICollection<Distillery> Distillery { get; set; }
    }
}
