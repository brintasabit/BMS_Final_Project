using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_Final.Bill;
using BMS_Final.Model;

namespace BMS_Final
{
    public partial class ProductCategory : Form
    {
        CategoryManager _categoryManager=new CategoryManager();
        Category _category=new Category();
        public ProductCategory()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _category.Code = textBoxCode.Text;
                _category.Name = textBoxName.Text;
                List<Category> categoriesCode = _categoryManager.SearchCategoriesCode(_category);
                List<Category> categoriesName = _categoryManager.SearchCategoriesName(_category);
                if (_category.Code.Length==0)
                {
                    MessageBox.Show("Code Can't Be Empty!");
                }
                else if(_category.Name.Length==0)
                {
                    MessageBox.Show("Name Can't Be Empty!");
                }
                else if (_category.Code.Length<4)
                {
                    MessageBox.Show("Code Must Be 4 Character");
                }
                else if (_category.Code.Length>4)
                {
                    MessageBox.Show("Code Must Not Exceed 4 Character!");
                }
                else if (categoriesCode.Count>0)
                {
                    MessageBox.Show("Code Exists!");
                }
                else if (categoriesName.Count>0)
                {
                    MessageBox.Show("Name Exists!");
                }
                else
                {
                    bool isSaved = _categoryManager.SaveInfo(_category);
                    if (isSaved)
                    {
                        MessageBox.Show("Saved");
                        dataGridViewCategory.DataSource = _categoryManager.ShowCategories(_category);
                    }
                }
                textBoxCode.Clear();
                textBoxName.Clear();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void dataGridViewCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
