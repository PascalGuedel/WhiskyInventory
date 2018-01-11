using System;
using System.Collections.Generic;

namespace WhiskyInventory.Data.Models
{
    public partial class Account
    {
        public Account()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }
}
