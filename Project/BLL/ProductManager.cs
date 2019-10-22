using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository;
using Project.Model;


namespace Project.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        //Catagory catagory = new Catagory();
        public bool IsNameExists(Product product)
        {
            return _productRepository.IsNameExists(product);
        }

        public bool IsCodeExist(Product product)
        {
            return _productRepository.IsCodeExist(product);
        }
        public bool AddProductInfo(Product product)
        {
            return _productRepository.AddProductInfo(product);
        }
        public List<Catagory> Display()
        {
           return _productRepository.Display();
        }

        public List<Product> DisplayProduct()
        {
           return _productRepository.DisplayProduct();
        }
    }
}
