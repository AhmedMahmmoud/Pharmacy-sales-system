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
    public partial class AddNewUser : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();

        public AddNewUser()
        {
            InitializeComponent();
        }

        private void lbl_adduserU_Click(object sender, EventArgs e)
        {

        }

        private void lbl_adduserSign_Click(object sender, EventArgs e)
        {

        }

        private void lbl_adduserP_Click(object sender, EventArgs e)
        {

        }

        private void AddnewuserSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPW.Text == "")
            {
                MessageBox.Show("Please Enter Data", "Error");
                return;
            }
            User u = new User();
            u.Name = txtUsername.Text;
            u.PassWord=int.Parse(txtPW.Text);
            db.Users.Add(u);
            db.SaveChanges();

            MessageBox.Show("Data Saved successfully","New User");
            txtUsername.Text = "";
            txtPW.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
