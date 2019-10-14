using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS_Final.Model;
using BMS_Final.Repository;

namespace BMS_Final.Bill
{
    class CategoryManager
    {
        CategoryRepository _categoryRepository=new CategoryRepository();
        public bool SaveInfo(Category _category)
        {
            return _categoryRepository.SaveInfo(_category);
        }

        public List<Category> ShowCategories(Category _category)
        {
            return _categoryRepository.ShowCategories(_category);
        }
    }
}
