using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Sales
    {  
        public int Sales_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Date { get; set; }
        public int Customer_Loyality { get; set; }
        public double GrandTotal { get; set; }
    }
}
