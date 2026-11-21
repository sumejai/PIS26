namespace PISVezba.Forms
{
    partial class FrmSobe
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
            this.lblTip = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.pnlUnos = new System.Windows.Forms.Panel();
            this.pnlLinija = new System.Windows.Forms.Panel();
            this.lblUnosNaslov = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblTipUnos = new System.Windows.Forms.Label();
            this.cmbTipUnos = new System.Windows.Forms.ComboBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblStatusUnos = new System.Windows.Forms.Label();
            this.cmbStatusUnos = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.dgvSobe = new System.Windows.Forms.DataGridView();
            this.pnlFilter.SuspendLayout();
            this.pnlUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblPretraga);
            this.pnlFilter.Controls.Add(this.txtPretraga);
            this.pnlFilter.Controls.Add(this.lblTip);
            this.pnlFilter.Controls.Add(this.cmbTip);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.cmbStatus);
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
            this.lblPretraga.Size = new System.Drawing.Size(70, 19);
            this.lblPretraga.TabIndex = 0;
            this.lblPretraga.Text = "Broj sobe";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPretraga.Location = new System.Drawing.Point(20, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(140, 27);
            this.txtPretraga.TabIndex = 1;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(180, 10);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(61, 19);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip sobe";
            // 
            // cmbTip
            // 
            this.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Svi tipovi",
            "Jednokrevetna",
            "Dvokrevetna",
            "Trokrevetna",
            "Apartman",
            "Lux apartman"});
            this.cmbTip.Location = new System.Drawing.Point(180, 32);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(160, 28);
            this.cmbTip.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(360, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Svi",
            "slobodna",
            "zauzeta"});
            this.cmbStatus.Location = new System.Drawing.Point(360, 32);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(120, 28);
            this.cmbStatus.TabIndex = 5;
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
            this.btnPretrazi.Location = new System.Drawing.Point(500, 28);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(100, 34);
            this.btnPretrazi.TabIndex = 6;
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
            this.btnPonisti.Location = new System.Drawing.Point(610, 28);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(90, 34);
            this.btnPonisti.TabIndex = 7;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            // 
            // pnlUnos
            // 
            this.pnlUnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUnos.Controls.Add(this.pnlLinija);
            this.pnlUnos.Controls.Add(this.lblUnosNaslov);
            this.pnlUnos.Controls.Add(this.lblBroj);
            this.pnlUnos.Controls.Add(this.txtBroj);
            this.pnlUnos.Controls.Add(this.lblTipUnos);
            this.pnlUnos.Controls.Add(this.cmbTipUnos);
            this.pnlUnos.Controls.Add(this.lblCena);
            this.pnlUnos.Controls.Add(this.txtCena);
            this.pnlUnos.Controls.Add(this.lblStatusUnos);
            this.pnlUnos.Controls.Add(this.cmbStatusUnos);
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
            this.lblUnosNaslov.Size = new System.Drawing.Size(110, 21);
            this.lblUnosNaslov.TabIndex = 8;
            this.lblUnosNaslov.Text = "Podaci o sobi";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(20, 48);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(70, 19);
            this.lblBroj.TabIndex = 9;
            this.lblBroj.Text = "Broj sobe";
            // 
            // txtBroj
            // 
            this.txtBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBroj.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBroj.Location = new System.Drawing.Point(20, 68);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(220, 27);
            this.txtBroj.TabIndex = 0;
            // 
            // lblTipUnos
            // 
            this.lblTipUnos.AutoSize = true;
            this.lblTipUnos.Location = new System.Drawing.Point(20, 108);
            this.lblTipUnos.Name = "lblTipUnos";
            this.lblTipUnos.Size = new System.Drawing.Size(61, 19);
            this.lblTipUnos.TabIndex = 10;
            this.lblTipUnos.Text = "Tip sobe";
            // 
            // cmbTipUnos
            // 
            this.cmbTipUnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipUnos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTipUnos.FormattingEnabled = true;
            this.cmbTipUnos.Items.AddRange(new object[] {
            "Jednokrevetna",
            "Dvokrevetna",
            "Trokrevetna",
            "Apartman",
            "Lux apartman"});
            this.cmbTipUnos.Location = new System.Drawing.Point(20, 128);
            this.cmbTipUnos.Name = "cmbTipUnos";
            this.cmbTipUnos.Size = new System.Drawing.Size(220, 28);
            this.cmbTipUnos.TabIndex = 1;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(20, 168);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(87, 19);
            this.lblCena.TabIndex = 11;
            this.lblCena.Text = "Cena po noći";
            // 
            // txtCena
            // 
            this.txtCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCena.Location = new System.Drawing.Point(20, 188);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(220, 27);
            this.txtCena.TabIndex = 2;
            // 
            // lblStatusUnos
            // 
            this.lblStatusUnos.AutoSize = true;
            this.lblStatusUnos.Location = new System.Drawing.Point(20, 228);
            this.lblStatusUnos.Name = "lblStatusUnos";
            this.lblStatusUnos.Size = new System.Drawing.Size(48, 19);
            this.lblStatusUnos.TabIndex = 12;
            this.lblStatusUnos.Text = "Status";
            // 
            // cmbStatusUnos
            // 
            this.cmbStatusUnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusUnos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStatusUnos.FormattingEnabled = true;
            this.cmbStatusUnos.Items.AddRange(new object[] {
            "slobodna",
            "zauzeta"});
            this.cmbStatusUnos.Location = new System.Drawing.Point(20, 248);
            this.cmbStatusUnos.Name = "cmbStatusUnos";
            this.cmbStatusUnos.Size = new System.Drawing.Size(220, 28);
            this.cmbStatusUnos.TabIndex = 3;
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
            // dgvSobe
            // 
            this.dgvSobe.AllowUserToAddRows = false;
            this.dgvSobe.AllowUserToDeleteRows = false;
            this.dgvSobe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSobe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSobe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSobe.BackgroundColor = System.Drawing.Color.White;
            this.dgvSobe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSobe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSobe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSobe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSobe.ColumnHeadersHeight = 38;
            this.dgvSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSobe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSobe.EnableHeadersVisualStyles = false;
            this.dgvSobe.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSobe.Location = new System.Drawing.Point(0, 80);
            this.dgvSobe.MultiSelect = false;
            this.dgvSobe.Name = "dgvSobe";
            this.dgvSobe.ReadOnly = true;
            this.dgvSobe.RowHeadersVisible = false;
            this.dgvSobe.RowTemplate.Height = 32;
            this.dgvSobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSobe.Size = new System.Drawing.Size(520, 460);
            this.dgvSobe.TabIndex = 2;
            // 
            // FrmSobe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.dgvSobe);
            this.Controls.Add(this.pnlUnos);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmSobe";
            this.Text = "Sobe";
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlUnos.ResumeLayout(false);
            this.pnlUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Panel pnlUnos;
        private System.Windows.Forms.Panel pnlLinija;
        private System.Windows.Forms.Label lblUnosNaslov;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label lblTipUnos;
        private System.Windows.Forms.ComboBox cmbTipUnos;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblStatusUnos;
        private System.Windows.Forms.ComboBox cmbStatusUnos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.DataGridView dgvSobe;
    }
}
