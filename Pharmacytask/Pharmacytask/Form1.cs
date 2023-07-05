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
    public partial class Form1 : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Login1_Click(object sender, EventArgs e)
        {
            

            if (txtUser.Text == "" || txtPW.Text == "")
            {
                MessageBox.Show("Please Enter UserName and PassWord ", "Failed");
                return;
            }

             //int a;
            // a = int.Parse(txtPW.Text);
            // if (txtUser.Text == "a" && a == 1)
            // {
            //    MessageBox.Show("Successful Operation", "Login");
            // }
            //    else
            //   {
            //        MessageBox.Show(" The username or password are incorrect", "Incorrect registration process");
            //        return;
            //   }

            int a;
            a = int.Parse(txtPW.Text);  
            var result = db.Users.Where(x=> x.Name==txtUser.Text && x.PassWord == a).ToList();
            if (result.Count() > 0)
            {
                MessageBox.Show("Successful Operation", "Login");
                MainScreen frm = new MainScreen();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" The username or password are incorrect", "Incorrect registration process");
                      return;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else 
            {
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
