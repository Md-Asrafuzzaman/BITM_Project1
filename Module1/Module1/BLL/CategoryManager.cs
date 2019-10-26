using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Data;
using  System.Data.SqlClient;
using System.Threading.Tasks;
using Module1.Model;
using  Module1.Repository;

namespace Module1.BLL
{
   public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public bool SaveData(CategoryModel categoryModel)
        {
            return _categoryRepository.SaveData(categoryModel);
        }

        public bool IsCodeExist(CategoryModel categoryModel)
        {
            return _categoryRepository.IsCodeExist(categoryModel);
        }

        public DataTable ShowAllInformation()
        {
            return _categoryRepository.ShowAllInformation();
        }

        public DataTable SeachInformation(CategoryModel categoryModel)
        {
            return _categoryRepository.SeachInformation(categoryModel);
        }

        public DataTable SearchName(CategoryModel categoryModel)
        {
            return _categoryRepository.SearchName(categoryModel);
        }

        public bool IsNameExist(CategoryModel categoryModel)
        {
            return _categoryRepository.IsNameExist(categoryModel);
        }

        public bool UpdateInformation(CategoryModel categoryModel)
        {
            return _categoryRepository.UpdateInformation(categoryModel);
        }



    }
}
