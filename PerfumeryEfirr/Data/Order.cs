using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeryEfirr.Data
{
    public class Order
    {
        public int Id { get; set; }

        public int IdPerfume { get; set; }
        public Perfumes Perfumes { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int Quantity { get; set; }
        public DateTime OrderedOn { get; set; }


    }
}
