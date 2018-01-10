using System;
using System.Collections.Generic;

namespace WhiskyInventory.Data.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string WhiskyName { get; set; }
        public int? Age { get; set; }
        public int DistilleryId { get; set; }
        public string Information { get; set; }

        public Account Account { get; set; }
        public Distillery Distillery { get; set; }
    }
}
