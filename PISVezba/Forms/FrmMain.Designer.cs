namespace PISVezba.Forms
{
    partial class FrmMain
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
            this.pnlMeni = new System.Windows.Forms.Panel();
            this.pnlGore = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnSobe = new System.Windows.Forms.Button();
            this.btnGosti = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblNaslovneStrane = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSadrzaj = new System.Windows.Forms.Panel();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblUputstvo = new System.Windows.Forms.Label();
            this.pnlMeni.SuspendLayout();
            this.pnlGore.SuspendLayout();
            this.pnlSadrzaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMeni
            // 
            this.pnlMeni.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMeni.Controls.Add(this.button4);
            this.pnlMeni.Controls.Add(this.btnGosti);
            this.pnlMeni.Controls.Add(this.btnSobe);
            this.pnlMeni.Controls.Add(this.btnRezervacije);
            this.pnlMeni.Controls.Add(this.btnPocetna);
            this.pnlMeni.Controls.Add(this.lblLogo);
            this.pnlMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMeni.Location = new System.Drawing.Point(0, 0);
            this.pnlMeni.Name = "pnlMeni";
            this.pnlMeni.Size = new System.Drawing.Size(220, 723);
            this.pnlMeni.TabIndex = 0;
            // 
            // pnlGore
            // 
            this.pnlGore.BackColor = System.Drawing.Color.White;
            this.pnlGore.Controls.Add(this.label2);
            this.pnlGore.Controls.Add(this.lblNaslovneStrane);
            this.pnlGore.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGore.Location = new System.Drawing.Point(220, 0);
            this.pnlGore.Name = "pnlGore";
            this.pnlGore.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pnlGore.Size = new System.Drawing.Size(772, 60);
            this.pnlGore.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Hotelski smeštaj";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPocetna
            // 
            this.btnPocetna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Location = new System.Drawing.Point(0, 100);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPocetna.Size = new System.Drawing.Size(220, 50);
            this.btnPocetna.TabIndex = 1;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.UseVisualStyleBackColor = true;
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacije.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.ForeColor = System.Drawing.Color.White;
            this.btnRezervacije.Location = new System.Drawing.Point(0, 150);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRezervacije.Size = new System.Drawing.Size(220, 50);
            this.btnRezervacije.TabIndex = 2;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervacije.UseVisualStyleBackColor = true;
            // 
            // btnSobe
            // 
            this.btnSobe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobe.ForeColor = System.Drawing.Color.White;
            this.btnSobe.Location = new System.Drawing.Point(0, 200);
            this.btnSobe.Name = "btnSobe";
            this.btnSobe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSobe.Size = new System.Drawing.Size(220, 50);
            this.btnSobe.TabIndex = 3;
            this.btnSobe.Text = "Sobe";
            this.btnSobe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobe.UseVisualStyleBackColor = true;
            // 
            // btnGosti
            // 
            this.btnGosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGosti.ForeColor = System.Drawing.Color.White;
            this.btnGosti.Location = new System.Drawing.Point(0, 250);
            this.btnGosti.Name = "btnGosti";
            this.btnGosti.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGosti.Size = new System.Drawing.Size(220, 50);
            this.btnGosti.TabIndex = 4;
            this.btnGosti.Text = "Gosti";
            this.btnGosti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGosti.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Goldenrod;
            this.button4.Location = new System.Drawing.Point(0, 673);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Odjava";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblNaslovneStrane
            // 
            this.lblNaslovneStrane.AutoSize = true;
            this.lblNaslovneStrane.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovneStrane.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslovneStrane.Location = new System.Drawing.Point(20, 14);
            this.lblNaslovneStrane.Name = "lblNaslovneStrane";
            this.lblNaslovneStrane.Size = new System.Drawing.Size(115, 38);
            this.lblNaslovneStrane.TabIndex = 0;
            this.lblNaslovneStrane.Text = "Početna";
            this.lblNaslovneStrane.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(352, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijavljeni korisnik";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSadrzaj
            // 
            this.pnlSadrzaj.Controls.Add(this.lblUputstvo);
            this.pnlSadrzaj.Controls.Add(this.lblDobrodosli);
            this.pnlSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSadrzaj.Location = new System.Drawing.Point(221, 61);
            this.pnlSadrzaj.Name = "pnlSadrzaj";
            this.pnlSadrzaj.Size = new System.Drawing.Size(772, 663);
            this.pnlSadrzaj.TabIndex = 2;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDobrodosli.Location = new System.Drawing.Point(30, 30);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(166, 41);
            this.lblDobrodosli.TabIndex = 0;
            this.lblDobrodosli.Text = "Dobrodošli";
            // 
            // lblUputstvo
            // 
            this.lblUputstvo.AutoSize = true;
            this.lblUputstvo.ForeColor = System.Drawing.Color.DimGray;
            this.lblUputstvo.Location = new System.Drawing.Point(32, 80);
            this.lblUputstvo.Name = "lblUputstvo";
            this.lblUputstvo.Size = new System.Drawing.Size(308, 23);
            this.lblUputstvo.TabIndex = 1;
            this.lblUputstvo.Text = "Izaberite opciju iz menija sa leve strane";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.pnlSadrzaj);
            this.Controls.Add(this.pnlGore);
            this.Controls.Add(this.pnlMeni);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1010, 770);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelski smeštaj";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMeni.ResumeLayout(false);
            this.pnlGore.ResumeLayout(false);
            this.pnlGore.PerformLayout();
            this.pnlSadrzaj.ResumeLayout(false);
            this.pnlSadrzaj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeni;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlGore;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGosti;
        private System.Windows.Forms.Button btnSobe;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNaslovneStrane;
        private System.Windows.Forms.Panel pnlSadrzaj;
        private System.Windows.Forms.Label lblUputstvo;
        private System.Windows.Forms.Label lblDobrodosli;
    }
}