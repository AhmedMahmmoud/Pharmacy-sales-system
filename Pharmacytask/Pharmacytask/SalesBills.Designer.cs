namespace Pharmacytask
{
    partial class SalesBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBills));
            this.richTxtNotes = new System.Windows.Forms.RichTextBox();
            this.NewproductNotes = new System.Windows.Forms.Label();
            this.salesbilsave = new System.Windows.Forms.Button();
            this.NewproductPrice = new System.Windows.Forms.Label();
            this.NewproductP = new System.Windows.Forms.Label();
            this.NewproductN = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacytaskDataSet1 = new Pharmacytask.PharmacytaskDataSet1();
            this.customerTableAdapter = new Pharmacytask.PharmacytaskDataSet1TableAdapters.CustomerTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacytaskDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxtNotes
            // 
            this.richTxtNotes.Location = new System.Drawing.Point(465, 56);
            this.richTxtNotes.Name = "richTxtNotes";
            this.richTxtNotes.Size = new System.Drawing.Size(200, 51);
            this.richTxtNotes.TabIndex = 67;
            this.richTxtNotes.Text = "";
            // 
            // NewproductNotes
            // 
            this.NewproductNotes.AutoSize = true;
            this.NewproductNotes.BackColor = System.Drawing.Color.Transparent;
            this.NewproductNotes.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductNotes.Location = new System.Drawing.Point(381, 83);
            this.NewproductNotes.Name = "NewproductNotes";
            this.NewproductNotes.Size = new System.Drawing.Size(71, 24);
            this.NewproductNotes.TabIndex = 66;
            this.NewproductNotes.Text = "Notes";
            // 
            // salesbilsave
            // 
            this.salesbilsave.BackColor = System.Drawing.Color.Transparent;
            this.salesbilsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesbilsave.BackgroundImage")));
            this.salesbilsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salesbilsave.FlatAppearance.BorderSize = 0;
            this.salesbilsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbilsave.Location = new System.Drawing.Point(274, 339);
            this.salesbilsave.Name = "salesbilsave";
            this.salesbilsave.Size = new System.Drawing.Size(103, 40);
            this.salesbilsave.TabIndex = 62;
            this.salesbilsave.UseVisualStyleBackColor = false;
            // 
            // NewproductPrice
            // 
            this.NewproductPrice.AutoSize = true;
            this.NewproductPrice.BackColor = System.Drawing.Color.Transparent;
            this.NewproductPrice.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductPrice.Location = new System.Drawing.Point(33, 83);
            this.NewproductPrice.Name = "NewproductPrice";
            this.NewproductPrice.Size = new System.Drawing.Size(74, 24);
            this.NewproductPrice.TabIndex = 61;
            this.NewproductPrice.Text = "Client";
            // 
            // NewproductP
            // 
            this.NewproductP.AutoSize = true;
            this.NewproductP.BackColor = System.Drawing.Color.Transparent;
            this.NewproductP.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductP.Location = new System.Drawing.Point(381, 26);
            this.NewproductP.Name = "NewproductP";
            this.NewproductP.Size = new System.Drawing.Size(60, 24);
            this.NewproductP.TabIndex = 60;
            this.NewproductP.Text = "Date";
            // 
            // NewproductN
            // 
            this.NewproductN.AutoSize = true;
            this.NewproductN.BackColor = System.Drawing.Color.Transparent;
            this.NewproductN.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductN.Location = new System.Drawing.Point(33, 26);
            this.NewproductN.Name = "NewproductN";
            this.NewproductN.Size = new System.Drawing.Size(176, 24);
            this.NewproductN.TabIndex = 59;
            this.NewproductN.Text = "Invoice number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 29);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 58;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Cus_id", true));
            this.comboBox1.DataSource = this.customerBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.ValueMember = "Cus_id";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.pharmacytaskDataSet1;
            // 
            // pharmacytaskDataSet1
            // 
            this.pharmacytaskDataSet1.DataSetName = "PharmacytaskDataSet1";
            this.pharmacytaskDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(719, 25);
            this.fillByToolStrip.TabIndex = 70;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // SalesBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 399);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTxtNotes);
            this.Controls.Add(this.NewproductNotes);
            this.Controls.Add(this.salesbilsave);
            this.Controls.Add(this.NewproductPrice);
            this.Controls.Add(this.NewproductP);
            this.Controls.Add(this.NewproductN);
            this.Controls.Add(this.txtName);
            this.Name = "SalesBills";
            this.Text = "SalesBills";
            this.Load += new System.EventHandler(this.SalesBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacytaskDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtNotes;
        private System.Windows.Forms.Label NewproductNotes;
        private System.Windows.Forms.Button salesbilsave;
        private System.Windows.Forms.Label NewproductPrice;
        private System.Windows.Forms.Label NewproductP;
        private System.Windows.Forms.Label NewproductN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private PharmacytaskDataSet1 pharmacytaskDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private PharmacytaskDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}