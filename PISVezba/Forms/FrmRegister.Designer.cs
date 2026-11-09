namespace PISVezba.Forms
{
    partial class FrmRegister
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlZaglavlje = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPodnaslov = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblRola = new System.Windows.Forms.Label();
            this.cmbRola = new System.Windows.Forms.ComboBox();
            this.pnlZaglavlje.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(40, 162);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 31);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 227);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(40, 415);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(155, 42);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registruj se";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Location = new System.Drawing.Point(205, 415);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Nazad na prijavu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 205);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 23);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Lozinka";
            // 
            // pnlZaglavlje
            // 
            this.pnlZaglavlje.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlZaglavlje.Controls.Add(this.lblPodnaslov);
            this.pnlZaglavlje.Controls.Add(this.lblNaslov);
            this.pnlZaglavlje.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZaglavlje.Location = new System.Drawing.Point(0, 0);
            this.pnlZaglavlje.Name = "pnlZaglavlje";
            this.pnlZaglavlje.Size = new System.Drawing.Size(382, 120);
            this.pnlZaglavlje.TabIndex = 6;
            // 
            // lblNaslov
            // 
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(0, 25);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(400, 40);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Hotelski smeštaj";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaslov.Click += new System.EventHandler(this.lblNaslov_Click);
            // 
            // lblPodnaslov
            // 
            this.lblPodnaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblPodnaslov.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPodnaslov.Location = new System.Drawing.Point(0, 70);
            this.lblPodnaslov.Name = "lblPodnaslov";
            this.lblPodnaslov.Size = new System.Drawing.Size(400, 25);
            this.lblPodnaslov.TabIndex = 1;
            this.lblPodnaslov.Text = "Kreiranje naloga";
            this.lblPodnaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(40, 270);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(135, 23);
            this.lblPassword2.TabIndex = 7;
            this.lblPassword2.Text = "Ponovite lozinku";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(40, 292);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(320, 30);
            this.txtPassword2.TabIndex = 8;
            this.txtPassword2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRola
            // 
            this.lblRola.AutoSize = true;
            this.lblRola.Location = new System.Drawing.Point(40, 335);
            this.lblRola.Name = "lblRola";
            this.lblRola.Size = new System.Drawing.Size(55, 23);
            this.lblRola.TabIndex = 9;
            this.lblRola.Text = "Uloga";
            // 
            // cmbRola
            // 
            this.cmbRola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRola.FormattingEnabled = true;
            this.cmbRola.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cmbRola.Location = new System.Drawing.Point(40, 357);
            this.cmbRola.Name = "cmbRola";
            this.cmbRola.Size = new System.Drawing.Size(320, 31);
            this.cmbRola.TabIndex = 10;
            // 
            // FrmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(382, 468);
            this.Controls.Add(this.cmbRola);
            this.Controls.Add(this.lblRola);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.pnlZaglavlje);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegister_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.pnlZaglavlje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlZaglavlje;
        private System.Windows.Forms.Label lblPodnaslov;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblRola;
        private System.Windows.Forms.ComboBox cmbRola;
    }
}