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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser user = new AddNewUser();
            user.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProduct p = new NewProduct();
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerList cus = new CustomerList();
            cus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuppliersList s = new SuppliersList();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductList form = new ProductList();
            form.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void addCostomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer c = new AddCustomer();
            c.Show();
        }

        private void addNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesBills s = new SalesBills();
            s.Show();
        }
    }
}
