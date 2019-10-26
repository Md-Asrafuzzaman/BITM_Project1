using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository;
using Project;
using Project.Model;

namespace Project.BLL
{
   public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        //Catagory catagory = new Catagory();
        public bool AddSupplierInfo(Supplier supplier)
        {
            return _supplierRepository.AddSupplierInfo(supplier);
        }
        public bool IsNameExists(Supplier name)
        {
            return _supplierRepository.IsNameExists(name);
        }

        public bool IsCodeExist(Supplier id)
        {
            return _supplierRepository.IsCodeExist(id);
        }
        public List<Supplier> Display()
        {
            return _supplierRepository.Display();
        }
    }
}
