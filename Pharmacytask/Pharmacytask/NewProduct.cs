using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacytask
{
    

    public partial class NewProduct : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();
        public NewProduct()
        {
            InitializeComponent();
        }

        private void NewproductSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || richTxtNotes.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please Enter all data ", "Failed");
                return;
            }
            else
            {


                Product p = new Product();
                p.Name = txtName.Text;
                p.ParCode = int.Parse(txtCode.Text);
                p.Price = decimal.Parse(txtPrice.Text);
                p.Notes = richTxtNotes.Text;
                p.Quantity = int.Parse(txtQuantity.Text);
                p.Ca_id = int.Parse(comboBox1.SelectedValue.ToString());
                db.Products.Add(p);
                db.SaveChanges();
                MessageBox.Show("Data Saved successfully", "New Product");
                ClearDataNewProduct();
            }
        }

        private void ClearDataNewProduct()
        {
            txtName.Text = "";
            txtCode.Text = "";
            txtPrice.Text = "";
            richTxtNotes.Text = "";
            txtQuantity.Text = "";
            comboBox1.Text = "";
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacytaskDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pharmacytaskDataSet.Category);

        }
    }
}
