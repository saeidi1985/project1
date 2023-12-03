using Project1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Name_textBox.Text) || string.IsNullOrEmpty(BrandName_textBox.Text) || string.IsNullOrEmpty(Count_textBox.Text))
                {
                    MessageBox.Show(" Please Enter  Valid Input");
                    return;

                }
                

                Product product = new Product(name: Name_textBox.Text,brandName: BrandName_textBox.Text,price: decimal.Parse(Price_textBox.Text),count: int.Parse(Count_textBox.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }
    }
}
