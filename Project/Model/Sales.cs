using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Sales
    {
        public int SL { get; set; }
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double MRP { get; set; }
        public double Total_MRP { get; set; }
    }
}
