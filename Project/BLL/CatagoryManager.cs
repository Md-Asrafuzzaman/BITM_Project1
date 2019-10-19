using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;
using Project.Model;
using Project.Repository;

namespace Project.BLL
{
   public class CatagoryManager
    {
        CatagoryRepository _catagoryRepository = new CatagoryRepository();
        //Catagory catagory = new Catagory();
        public bool AddCategoryInfo(Catagory category)
        {
            return _catagoryRepository.AddCategoryInfo(category);
        }
        public bool IsNameExists(Catagory catagory)
        {
            return _catagoryRepository.IsNameExists(catagory);
        }

        public bool IsCodeExist(Catagory catagory)
        {
            return _catagoryRepository.IsCodeExist(catagory);
        }
        public List<Catagory> Display()
        {
            return _catagoryRepository.Display();
        }
    }
}
