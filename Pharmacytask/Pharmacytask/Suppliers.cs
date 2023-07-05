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
    public partial class Suppliers : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();

        public Suppliers()
        {
            InitializeComponent();
        }

        private void NewproductSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCname.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || richTxtNotes.Text == "")
            {
                MessageBox.Show("Please Enter all data ", "Failed");
                return;
            }
            else
            {
                Supplier s = new Supplier();
                s.Name = txtName.Text;
                s.CompanyName = txtCname.Text;
                s.Phone = int.Parse(txtPhone.Text);
                s.Notes = richTxtNotes.Text;
                s.Email = txtEmail.Text;
                db.Suppliers.Add(s);
                db.SaveChanges();
                MessageBox.Show("Data Saved successfully", "New supplier");

                NewMethod();
            }
        }

        private void NewMethod()
        {
            txtName.Text = "";
            txtCname.Text = "";
            txtPhone.Text = "";
            richTxtNotes.Text = "";
            txtEmail.Text = "";
        }
    }
}
