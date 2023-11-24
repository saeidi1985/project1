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
                Random random = new Random();
                int Idnumber = random.Next(minValue: 1, maxValue: 1000);

                Product product = new Product();
                product.Id = Idnumber;
                product.Name = Name_textBox.Text;
                product.BrandName = BrandName_textBox.Text;
                product.count = int.Parse(Count_textBox.Text);
                product.Price = decimal.Parse(Price_textBox.Text);
                product.IsActive = IsActive_checkBox.Checked;
                product.Creationdate = DateTime.Now;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }
    }
}
