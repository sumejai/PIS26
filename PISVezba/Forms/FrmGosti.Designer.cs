namespace PISVezba.Forms
{
    partial class FrmGosti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretragaKarta = new System.Windows.Forms.Label();
            this.txtPretragaKarta = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.pnlUnos = new System.Windows.Forms.Panel();
            this.pnlLinija = new System.Windows.Forms.Panel();
            this.lblUnosNaslov = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblBrojKarte = new System.Windows.Forms.Label();
            this.txtBrojKarte = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.pnlFilter.SuspendLayout();
            this.pnlUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblPretraga);
            this.pnlFilter.Controls.Add(this.txtPretraga);
            this.pnlFilter.Controls.Add(this.lblPretragaKarta);
            this.pnlFilter.Controls.Add(this.txtPretragaKarta);
            this.pnlFilter.Controls.Add(this.btnPretrazi);
            this.pnlFilter.Controls.Add(this.btnPonisti);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(780, 80);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(20, 10);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(103, 19);
            this.lblPretraga.TabIndex = 0;
            this.lblPretraga.Text = "Ime ili prezime";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPretraga.Location = new System.Drawing.Point(20, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(200, 27);
            this.txtPretraga.TabIndex = 1;
            // 
            // lblPretragaKarta
            // 
            this.lblPretragaKarta.AutoSize = true;
            this.lblPretragaKarta.Location = new System.Drawing.Point(240, 10);
            this.lblPretragaKarta.Name = "lblPretragaKarta";
            this.lblPretragaKarta.Size = new System.Drawing.Size(115, 19);
            this.lblPretragaKarta.TabIndex = 2;
            this.lblPretragaKarta.Text = "Broj lične karte";
            // 
            // txtPretragaKarta
            // 
            this.txtPretragaKarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPretragaKarta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPretragaKarta.Location = new System.Drawing.Point(240, 32);
            this.txtPretragaKarta.Name = "txtPretragaKarta";
            this.txtPretragaKarta.Size = new System.Drawing.Size(180, 27);
            this.txtPretragaKarta.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(440, 28);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(100, 34);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.White;
            this.btnPonisti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonisti.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPonisti.FlatAppearance.BorderSize = 1;
            this.btnPonisti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPonisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonisti.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPonisti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPonisti.Location = new System.Drawing.Point(550, 28);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(90, 34);
            this.btnPonisti.TabIndex = 5;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            // 
            // pnlUnos
            // 
            this.pnlUnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUnos.Controls.Add(this.pnlLinija);
            this.pnlUnos.Controls.Add(this.lblUnosNaslov);
            this.pnlUnos.Controls.Add(this.lblIme);
            this.pnlUnos.Controls.Add(this.txtIme);
            this.pnlUnos.Controls.Add(this.lblPrezime);
            this.pnlUnos.Controls.Add(this.txtPrezime);
            this.pnlUnos.Controls.Add(this.lblBrojKarte);
            this.pnlUnos.Controls.Add(this.txtBrojKarte);
            this.pnlUnos.Controls.Add(this.lblTelefon);
            this.pnlUnos.Controls.Add(this.txtTelefon);
            this.pnlUnos.Controls.Add(this.btnDodaj);
            this.pnlUnos.Controls.Add(this.btnIzmeni);
            this.pnlUnos.Controls.Add(this.btnObrisi);
            this.pnlUnos.Controls.Add(this.btnOcisti);
            this.pnlUnos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUnos.Location = new System.Drawing.Point(520, 80);
            this.pnlUnos.Name = "pnlUnos";
            this.pnlUnos.Size = new System.Drawing.Size(260, 460);
            this.pnlUnos.TabIndex = 1;
            // 
            // pnlLinija
            // 
            this.pnlLinija.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLinija.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLinija.Location = new System.Drawing.Point(0, 0);
            this.pnlLinija.Name = "pnlLinija";
            this.pnlLinija.Size = new System.Drawing.Size(1, 460);
            this.pnlLinija.TabIndex = 20;
            // 
            // lblUnosNaslov
            // 
            this.lblUnosNaslov.AutoSize = true;
            this.lblUnosNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblUnosNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUnosNaslov.Location = new System.Drawing.Point(20, 12);
            this.lblUnosNaslov.Name = "lblUnosNaslov";
            this.lblUnosNaslov.Size = new System.Drawing.Size(121, 21);
            this.lblUnosNaslov.TabIndex = 8;
            this.lblUnosNaslov.Text = "Podaci o gostu";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(20, 48);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(31, 19);
            this.lblIme.TabIndex = 9;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIme.Location = new System.Drawing.Point(20, 68);
            this.txtIme.MaxLength = 45;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(220, 27);
            this.txtIme.TabIndex = 0;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(20, 108);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(58, 19);
            this.lblPrezime.TabIndex = 10;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrezime.Location = new System.Drawing.Point(20, 128);
            this.txtPrezime.MaxLength = 45;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(220, 27);
            this.txtPrezime.TabIndex = 1;
            // 
            // lblBrojKarte
            // 
            this.lblBrojKarte.AutoSize = true;
            this.lblBrojKarte.Location = new System.Drawing.Point(20, 168);
            this.lblBrojKarte.Name = "lblBrojKarte";
            this.lblBrojKarte.Size = new System.Drawing.Size(115, 19);
            this.lblBrojKarte.TabIndex = 11;
            this.lblBrojKarte.Text = "Broj lične karte";
            // 
            // txtBrojKarte
            // 
            this.txtBrojKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrojKarte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBrojKarte.Location = new System.Drawing.Point(20, 188);
            this.txtBrojKarte.MaxLength = 20;
            this.txtBrojKarte.Name = "txtBrojKarte";
            this.txtBrojKarte.Size = new System.Drawing.Size(220, 27);
            this.txtBrojKarte.TabIndex = 2;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 228);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(98, 19);
            this.lblTelefon.TabIndex = 12;
            this.lblTelefon.Text = "Broj telefona";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTelefon.Location = new System.Drawing.Point(20, 248);
            this.txtTelefon.MaxLength = 20;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 27);
            this.txtTelefon.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(20, 300);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 36);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.White;
            this.btnIzmeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmeni.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnIzmeni.FlatAppearance.BorderSize = 1;
            this.btnIzmeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnIzmeni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIzmeni.Location = new System.Drawing.Point(135, 300);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(105, 36);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Firebrick;
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(20, 344);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 36);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.White;
            this.btnOcisti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcisti.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnOcisti.FlatAppearance.BorderSize = 1;
            this.btnOcisti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcisti.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnOcisti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOcisti.Location = new System.Drawing.Point(135, 344);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(105, 36);
            this.btnOcisti.TabIndex = 7;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            // 
            // dgvGosti
            // 
            this.dgvGosti.AllowUserToAddRows = false;
            this.dgvGosti.AllowUserToDeleteRows = false;
            this.dgvGosti.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGosti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGosti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGosti.BackgroundColor = System.Drawing.Color.White;
            this.dgvGosti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGosti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGosti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGosti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGosti.ColumnHeadersHeight = 38;
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGosti.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGosti.EnableHeadersVisualStyles = false;
            this.dgvGosti.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvGosti.Location = new System.Drawing.Point(0, 80);
            this.dgvGosti.MultiSelect = false;
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.ReadOnly = true;
            this.dgvGosti.RowHeadersVisible = false;
            this.dgvGosti.RowTemplate.Height = 32;
            this.dgvGosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGosti.Size = new System.Drawing.Size(520, 460);
            this.dgvGosti.TabIndex = 2;
            // 
            // FrmGosti
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.pnlUnos);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmGosti";
            this.Text = "Gosti";
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlUnos.ResumeLayout(false);
            this.pnlUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretragaKarta;
        private System.Windows.Forms.TextBox txtPretragaKarta;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Panel pnlUnos;
        private System.Windows.Forms.Panel pnlLinija;
        private System.Windows.Forms.Label lblUnosNaslov;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblBrojKarte;
        private System.Windows.Forms.TextBox txtBrojKarte;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.DataGridView dgvGosti;
    }
}