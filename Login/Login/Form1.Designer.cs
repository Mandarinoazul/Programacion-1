namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panellogin = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.Linkpassword = new System.Windows.Forms.LinkLabel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.Panellogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panellogin
            // 
            this.Panellogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.Panellogin.Controls.Add(this.pictureBox3);
            this.Panellogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panellogin.Location = new System.Drawing.Point(0, 0);
            this.Panellogin.Name = "Panellogin";
            this.Panellogin.Size = new System.Drawing.Size(250, 304);
            this.Panellogin.TabIndex = 0;
            this.Panellogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panellogin_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Txtusername
            // 
            this.Txtusername.BackColor = System.Drawing.Color.Black;
            this.Txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtusername.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtusername.ForeColor = System.Drawing.Color.DimGray;
            this.Txtusername.Location = new System.Drawing.Point(287, 65);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(458, 32);
            this.Txtusername.TabIndex = 1;
            this.Txtusername.Text = "USUARIO";
            this.Txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtusername.TextChanged += new System.EventHandler(this.Txtusername_TextChanged);
            this.Txtusername.Enter += new System.EventHandler(this.Txtusername_Enter);
            this.Txtusername.Leave += new System.EventHandler(this.Txtusername_Leave);
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.Color.DimGray;
            this.lblusuario.Enabled = false;
            this.lblusuario.Location = new System.Drawing.Point(287, 100);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(458, 1);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "lblusuario";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(287, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 1);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Txtpassword
            // 
            this.Txtpassword.BackColor = System.Drawing.Color.Black;
            this.Txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtpassword.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtpassword.ForeColor = System.Drawing.Color.DimGray;
            this.Txtpassword.Location = new System.Drawing.Point(287, 116);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(458, 32);
            this.Txtpassword.TabIndex = 2;
            this.Txtpassword.Text = "PASSWORD";
            this.Txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtpassword.Enter += new System.EventHandler(this.Txtpassword_Enter);
            this.Txtpassword.Leave += new System.EventHandler(this.Txtpassword_Leave);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllogin.ForeColor = System.Drawing.Color.DimGray;
            this.lbllogin.Location = new System.Drawing.Point(457, 9);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(106, 36);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "LOGIN";
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Btnlogin.FlatAppearance.BorderSize = 0;
            this.Btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlogin.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnlogin.ForeColor = System.Drawing.Color.DimGray;
            this.Btnlogin.Location = new System.Drawing.Point(287, 179);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(458, 31);
            this.Btnlogin.TabIndex = 3;
            this.Btnlogin.Text = "ACCEDER";
            this.Btnlogin.UseVisualStyleBackColor = false;
            // 
            // Linkpassword
            // 
            this.Linkpassword.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.Linkpassword.AutoSize = true;
            this.Linkpassword.BackColor = System.Drawing.Color.Black;
            this.Linkpassword.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Linkpassword.LinkColor = System.Drawing.Color.DimGray;
            this.Linkpassword.Location = new System.Drawing.Point(409, 228);
            this.Linkpassword.Name = "Linkpassword";
            this.Linkpassword.Size = new System.Drawing.Size(206, 23);
            this.Linkpassword.TabIndex = 0;
            this.Linkpassword.TabStop = true;
            this.Linkpassword.Text = "Ha olvidado la contraseña?";
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(757, 6);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 5;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(731, 6);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(17, 17);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 6;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.Btnminimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 304);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.Linkpassword);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.Panellogin);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Panellogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panellogin;
        private TextBox Txtusername;
        private Label lblusuario;
        private Label label1;
        private TextBox Txtpassword;
        private Label lbllogin;
        private Button Btnlogin;
        private LinkLabel Linkpassword;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox pictureBox3;
    }
}