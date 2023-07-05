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
    public partial class AddCustomer : Form

    {
        PharmacytaskEntities db = new PharmacytaskEntities();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void NewproductSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || richTxtNotes.Text == "" || txtCompany.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Please Enter all data ", "Failed");
                return;
            }
            else
            {
                Customer c = new Customer();
                c.Name = txtName.Text;
                c.Address = txtAddress.Text;
                c.Phone = int.Parse(txtPhone.Text);
                c.Notes = richTxtNotes.Text;
                c.Company = txtCompany.Text;
                c.age = int.Parse(txtAge.Text);
                c.Active = checkBox1.Checked;

                db.Customers.Add(c);
                db.SaveChanges();
                ClearDataCustomer();

                MessageBox.Show("Data Saved successfully", "New Customer");
            }
        }

        private void ClearDataCustomer()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtAge.Clear();
            txtCompany.Clear();
            richTxtNotes.Clear();
            checkBox1.Checked = false;
        }

        private void AddCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
                  
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
