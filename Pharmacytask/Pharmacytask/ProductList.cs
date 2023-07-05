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
    public partial class ProductList : Form
    {
        PharmacytaskEntities db = new PharmacytaskEntities();
        int id;
        Product result; // golbal variable
        public ProductList()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Products.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             id = int .Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); // select id
             result = db.Products.SingleOrDefault(x => x.P_id == id); // select row
            // عايز اعرض كل حاجه الخانه بتاعتها
            txtformName.Text= result.Name;
            txtParcode.Text = result.ParCode.ToString();
            txtPrice.Text= result.Price.ToString();
            txtformNotes.Text= result.Notes;
        }


        private void ProductList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int p = int.Parse(txtpparcode.Text);
            if (txtProductname.Text == "")
            { 
                dataGridView1.DataSource = db.Products.Where(x => x.ParCode == p ).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Products.Where(x => x.ParCode == p || x.Name.Contains(txtProductname.Text)).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                result = db.Products.SingleOrDefault(x => x.P_id == id);
                result.Name = txtformName.Text;
                result.ParCode = int.Parse(txtParcode.Text);
                result.Price = decimal.Parse(txtPrice.Text);
                result.Notes = txtformNotes.Text;
                db.SaveChanges();
                MessageBox.Show("Saved Successfully", "Update");
                dataGridView1.DataSource = db.Products.ToList(); // == refreash
            }
            catch 
            {
                // عشان يعمل سيليكت لأول صف تاني بدون أخطاء اللي هو مش لاقي صف يعني يعمله سيليكت
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRaw = db.Products.Find(id);
            db.Products.Remove(selectedRaw);
            db.SaveChanges();
            MessageBox.Show("Saved successfully","Delete");
            dataGridView1.DataSource= db.Products.ToList(); // to refreash
        }
    }
}
