namespace Pharmacytask
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login1 = new System.Windows.Forms.Button();
            this.lbl_loginSignIn = new System.Windows.Forms.Label();
            this.lbl_loginP = new System.Windows.Forms.Label();
            this.lbl_loginU = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login1
            // 
            this.Login1.BackColor = System.Drawing.Color.Transparent;
            this.Login1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login1.BackgroundImage")));
            this.Login1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login1.FlatAppearance.BorderSize = 0;
            this.Login1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login1.Location = new System.Drawing.Point(242, 298);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(103, 40);
            this.Login1.TabIndex = 17;
            this.Login1.UseVisualStyleBackColor = false;
            this.Login1.Click += new System.EventHandler(this.Login1_Click);
            // 
            // lbl_loginSignIn
            // 
            this.lbl_loginSignIn.AutoSize = true;
            this.lbl_loginSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginSignIn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginSignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_loginSignIn.Location = new System.Drawing.Point(299, 35);
            this.lbl_loginSignIn.Name = "lbl_loginSignIn";
            this.lbl_loginSignIn.Size = new System.Drawing.Size(85, 24);
            this.lbl_loginSignIn.TabIndex = 16;
            this.lbl_loginSignIn.Text = "Sign In";
            // 
            // lbl_loginP
            // 
            this.lbl_loginP.AutoSize = true;
            this.lbl_loginP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginP.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_loginP.Location = new System.Drawing.Point(83, 200);
            this.lbl_loginP.Name = "lbl_loginP";
            this.lbl_loginP.Size = new System.Drawing.Size(115, 24);
            this.lbl_loginP.TabIndex = 15;
            this.lbl_loginP.Text = "Password";
            // 
            // lbl_loginU
            // 
            this.lbl_loginU.AutoSize = true;
            this.lbl_loginU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginU.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_loginU.Location = new System.Drawing.Point(74, 128);
            this.lbl_loginU.Name = "lbl_loginU";
            this.lbl_loginU.Size = new System.Drawing.Size(124, 24);
            this.lbl_loginU.TabIndex = 14;
            this.lbl_loginU.Text = "User Name";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(290, 128);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(127, 20);
            this.txtUser.TabIndex = 13;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(290, 200);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(127, 20);
            this.txtPW.TabIndex = 12;
            this.txtPW.UseSystemPasswordChar = true;
            this.txtPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("VIP Hala Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(290, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 27);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(362, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.lbl_loginSignIn);
            this.Controls.Add(this.lbl_loginP);
            this.Controls.Add(this.lbl_loginU);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPW);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login1;
        private System.Windows.Forms.Label lbl_loginSignIn;
        private System.Windows.Forms.Label lbl_loginP;
        private System.Windows.Forms.Label lbl_loginU;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

