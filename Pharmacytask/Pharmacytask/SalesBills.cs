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
    public partial class SalesBills : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();
        public SalesBills()
        {
            InitializeComponent();
            
        }

        private void SalesBills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacytaskDataSet1.Customer' table. You can move, or remove it, as needed.
          //  this.customerTableAdapter.Fill(this.pharmacytaskDataSet1.Customer);
            this.customerTableAdapter.FillBy(this.pharmacytaskDataSet1.Customer);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          /*  try
            {
                this.customerTableAdapter.FillBy(this.pharmacytaskDataSet1.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          */
        }
    }
}
