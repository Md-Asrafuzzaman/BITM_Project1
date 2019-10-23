using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Model
{
   public class Customer
    {
        public int Id { get; set; }
        public int SL { get; set; }
        public string Customer_Code { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Contact { get; set; }
        public int Customer_LoyalityPoint { get; set; }

    }
}
