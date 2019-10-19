using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;
using Project.Repository;
using Project.Model;


namespace Project.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        //Catagory catagory = new Catagory();
        public bool AddCustomerInfo(Customer customer)
        {
            return _customerRepository.AddCustomerInfo(customer);
        }
        public bool IsNameExists(Customer name)
        {
            return _customerRepository.IsNameExists(name);
        }

        public bool IsCodeExist(Customer id)
        {
            return _customerRepository.IsCodeExist(id);
        }
        public List<Customer> Display()
        {
            return _customerRepository.Display();
        }

    }
}
