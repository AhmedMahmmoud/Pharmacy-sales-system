namespace Pharmacytask
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            this.richTxtNotes = new System.Windows.Forms.RichTextBox();
            this.NewproductNotes = new System.Windows.Forms.Label();
            this.NewproductQ = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.NewproductSave = new System.Windows.Forms.Button();
            this.NewproductPrice = new System.Windows.Forms.Label();
            this.NewproductP = new System.Windows.Forms.Label();
            this.NewproductN = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacytaskDataSet = new Pharmacytask.PharmacytaskDataSet();
            this.categoryTableAdapter = new Pharmacytask.PharmacytaskDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacytaskDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxtNotes
            // 
            this.richTxtNotes.Location = new System.Drawing.Point(235, 185);
            this.richTxtNotes.Name = "richTxtNotes";
            this.richTxtNotes.Size = new System.Drawing.Size(127, 96);
            this.richTxtNotes.TabIndex = 54;
            this.richTxtNotes.Text = "";
            // 
            // NewproductNotes
            // 
            this.NewproductNotes.AutoSize = true;
            this.NewproductNotes.BackColor = System.Drawing.Color.Transparent;
            this.NewproductNotes.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductNotes.Location = new System.Drawing.Point(65, 222);
            this.NewproductNotes.Name = "NewproductNotes";
            this.NewproductNotes.Size = new System.Drawing.Size(71, 24);
            this.NewproductNotes.TabIndex = 53;
            this.NewproductNotes.Text = "Notes";
            // 
            // NewproductQ
            // 
            this.NewproductQ.AutoSize = true;
            this.NewproductQ.BackColor = System.Drawing.Color.Transparent;
            this.NewproductQ.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductQ.Location = new System.Drawing.Point(400, 40);
            this.NewproductQ.Name = "NewproductQ";
            this.NewproductQ.Size = new System.Drawing.Size(106, 24);
            this.NewproductQ.TabIndex = 52;
            this.NewproductQ.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(512, 31);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 33);
            this.txtQuantity.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(235, 121);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(127, 34);
            this.txtPrice.TabIndex = 50;
            // 
            // NewproductSave
            // 
            this.NewproductSave.BackColor = System.Drawing.Color.Transparent;
            this.NewproductSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewproductSave.BackgroundImage")));
            this.NewproductSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewproductSave.FlatAppearance.BorderSize = 0;
            this.NewproductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewproductSave.Location = new System.Drawing.Point(268, 329);
            this.NewproductSave.Name = "NewproductSave";
            this.NewproductSave.Size = new System.Drawing.Size(103, 40);
            this.NewproductSave.TabIndex = 49;
            this.NewproductSave.UseVisualStyleBackColor = false;
            this.NewproductSave.Click += new System.EventHandler(this.NewproductSave_Click);
            // 
            // NewproductPrice
            // 
            this.NewproductPrice.AutoSize = true;
            this.NewproductPrice.BackColor = System.Drawing.Color.Transparent;
            this.NewproductPrice.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductPrice.Location = new System.Drawing.Point(55, 131);
            this.NewproductPrice.Name = "NewproductPrice";
            this.NewproductPrice.Size = new System.Drawing.Size(64, 24);
            this.NewproductPrice.TabIndex = 46;
            this.NewproductPrice.Text = "Price";
            // 
            // NewproductP
            // 
            this.NewproductP.AutoSize = true;
            this.NewproductP.BackColor = System.Drawing.Color.Transparent;
            this.NewproductP.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductP.Location = new System.Drawing.Point(53, 69);
            this.NewproductP.Name = "NewproductP";
            this.NewproductP.Size = new System.Drawing.Size(100, 24);
            this.NewproductP.TabIndex = 45;
            this.NewproductP.Text = "ParCode";
            // 
            // NewproductN
            // 
            this.NewproductN.AutoSize = true;
            this.NewproductN.BackColor = System.Drawing.Color.Transparent;
            this.NewproductN.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewproductN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewproductN.Location = new System.Drawing.Point(53, 16);
            this.NewproductN.Name = "NewproductN";
            this.NewproductN.Size = new System.Drawing.Size(70, 24);
            this.NewproductN.TabIndex = 44;
            this.NewproductN.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 7);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 33);
            this.txtName.TabIndex = 43;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(235, 59);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(127, 34);
            this.txtCode.TabIndex = 42;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Category.Location = new System.Drawing.Point(400, 165);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(107, 24);
            this.Category.TabIndex = 55;
            this.Category.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(512, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.ValueMember = "Ca_id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pharmacytaskDataSet;
            // 
            // pharmacytaskDataSet
            // 
            this.pharmacytaskDataSet.DataSetName = "PharmacytaskDataSet";
            this.pharmacytaskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 377);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.richTxtNotes);
            this.Controls.Add(this.NewproductNotes);
            this.Controls.Add(this.NewproductQ);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.NewproductSave);
            this.Controls.Add(this.NewproductPrice);
            this.Controls.Add(this.NewproductP);
            this.Controls.Add(this.NewproductN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacytaskDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtNotes;
        private System.Windows.Forms.Label NewproductNotes;
        private System.Windows.Forms.Label NewproductQ;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button NewproductSave;
        private System.Windows.Forms.Label NewproductPrice;
        private System.Windows.Forms.Label NewproductP;
        private System.Windows.Forms.Label NewproductN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox comboBox1;
        private PharmacytaskDataSet pharmacytaskDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PharmacytaskDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}