using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.db
{
    public partial class ActionType
    {
        public ActionType()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
