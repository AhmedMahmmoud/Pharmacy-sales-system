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
    public partial class SuppliersList : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();
        public SuppliersList()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Suppliers.ToList();
        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {

        }
    }
}
