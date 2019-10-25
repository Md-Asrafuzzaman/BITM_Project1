using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public int SL { get; set; }
        public string Supplier_Code { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Address { get; set; }
        public string Supplier_Email { get; set; }
        public string Supplier_Contact { get; set; }
        public int Contact_Person { get; set; }
    }
}
