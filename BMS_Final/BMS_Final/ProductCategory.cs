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
            _category.Code = textBoxCode.Text;
            _category.Name = textBoxName.Text;
            bool isSaved = _categoryManager.SaveInfo(_category);
            if (isSaved)
            {
                MessageBox.Show("Saved");
                dataGridViewCategory.DataSource = _categoryManager.ShowCategories(_category);
            }
        }

        private void dataGridViewCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
