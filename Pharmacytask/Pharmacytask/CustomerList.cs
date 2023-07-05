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
    public partial class CustomerList : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();
        public CustomerList()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {

        }
    }
}
