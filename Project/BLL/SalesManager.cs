using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using Project.Repository;
namespace Project.BLL
{
    public class SalesManager
    {
        SalesRepository _salesRepository = new SalesRepository();
        public List<Catagory> DisplayCategory()
        {
            return _salesRepository.DisplayCategory();
        }

        public List<Customer> DisplayCustomer()
        {
            return _salesRepository.DisplayCustomer();
        }
        public List<Product> DisplayProduct()
        {
            return _salesRepository.DisplayProduct();
        }
    }
}
