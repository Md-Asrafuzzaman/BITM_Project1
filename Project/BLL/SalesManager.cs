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

        public List<Product> DisplayProductByCategoryID(string catagory)
        {
            return _salesRepository.DisplayProductByCategoryID(catagory);
        }
        public int DisplayCustomerLoylityPoint(string customerName)
        {
            return _salesRepository.DisplayCustomerLoylityPoint(customerName);
        }
        public int AddSales(Sales sales)
        {
            return _salesRepository.AddSales(sales);
        }

        public bool AddSalesItem(SalesItems salesItems)
        {
            return _salesRepository.AddSalesItem(salesItems);
        }
    }
}
