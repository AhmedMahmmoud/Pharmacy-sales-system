namespace Pharmacytask
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.AddnewuserSave = new System.Windows.Forms.Button();
            this.lbl_adduserSign = new System.Windows.Forms.Label();
            this.lbl_adduserP = new System.Windows.Forms.Label();
            this.lbl_adduserU = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddnewuserSave
            // 
            this.AddnewuserSave.BackColor = System.Drawing.Color.Transparent;
            this.AddnewuserSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddnewuserSave.BackgroundImage")));
            this.AddnewuserSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddnewuserSave.FlatAppearance.BorderSize = 0;
            this.AddnewuserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddnewuserSave.Location = new System.Drawing.Point(320, 310);
            this.AddnewuserSave.Name = "AddnewuserSave";
            this.AddnewuserSave.Size = new System.Drawing.Size(103, 40);
            this.AddnewuserSave.TabIndex = 30;
            this.AddnewuserSave.UseVisualStyleBackColor = false;
            this.AddnewuserSave.Click += new System.EventHandler(this.AddnewuserSave_Click);
            // 
            // lbl_adduserSign
            // 
            this.lbl_adduserSign.AutoSize = true;
            this.lbl_adduserSign.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adduserSign.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adduserSign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_adduserSign.Location = new System.Drawing.Point(338, 23);
            this.lbl_adduserSign.Name = "lbl_adduserSign";
            this.lbl_adduserSign.Size = new System.Drawing.Size(85, 24);
            this.lbl_adduserSign.TabIndex = 27;
            this.lbl_adduserSign.Text = "Sign In";
            this.lbl_adduserSign.Click += new System.EventHandler(this.lbl_adduserSign_Click);
            // 
            // lbl_adduserP
            // 
            this.lbl_adduserP.AutoSize = true;
            this.lbl_adduserP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adduserP.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adduserP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_adduserP.Location = new System.Drawing.Point(121, 190);
            this.lbl_adduserP.Name = "lbl_adduserP";
            this.lbl_adduserP.Size = new System.Drawing.Size(115, 24);
            this.lbl_adduserP.TabIndex = 26;
            this.lbl_adduserP.Text = "Password";
            this.lbl_adduserP.Click += new System.EventHandler(this.lbl_adduserP_Click);
            // 
            // lbl_adduserU
            // 
            this.lbl_adduserU.AutoSize = true;
            this.lbl_adduserU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adduserU.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adduserU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_adduserU.Location = new System.Drawing.Point(121, 114);
            this.lbl_adduserU.Name = "lbl_adduserU";
            this.lbl_adduserU.Size = new System.Drawing.Size(124, 24);
            this.lbl_adduserU.TabIndex = 25;
            this.lbl_adduserU.Text = "User Name";
            this.lbl_adduserU.Click += new System.EventHandler(this.lbl_adduserU_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(308, 105);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(127, 33);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(308, 180);
            this.txtPW.Multiline = true;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(127, 34);
            this.txtPW.TabIndex = 23;
            this.txtPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 406);
            this.Controls.Add(this.AddnewuserSave);
            this.Controls.Add(this.lbl_adduserSign);
            this.Controls.Add(this.lbl_adduserP);
            this.Controls.Add(this.lbl_adduserU);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPW);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddnewuserSave;
        private System.Windows.Forms.Label lbl_adduserSign;
        private System.Windows.Forms.Label lbl_adduserP;
        private System.Windows.Forms.Label lbl_adduserU;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPW;
    }
}