using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
  public  class Product
    {
        public int Product_Id { get; set; }
        public int SL { get; set; }
        public string Product_Code { get; set; }
        public string Product_Name { get; set; }
        public string Product_Category { get; set; }
        public string Product_RecordedLevel { get; set; }
        public string Product_Description { get; set; }
    }
}   
