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
        public bool AddProductInfo(string catagory, string name, string code, string recordedLevel, string description)
        {
            return _productRepository.AddProductInfo(catagory, name, code, recordedLevel, description);
        }
    }
}
