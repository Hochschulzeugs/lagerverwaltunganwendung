namespace lagerverwaltunganwendung
{
    partial class Form9
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
            this.b_back = new System.Windows.Forms.Button();
            this.dg_lieferscheine = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_bestellungen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_lsdetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_lsartikel = new System.Windows.Forms.DataGridView();
            this.gb_checkartikel = new System.Windows.Forms.GroupBox();
            this.b_edit_anzahl = new System.Windows.Forms.Button();
            this.b_delete_artikel = new System.Windows.Forms.Button();
            this.b_newls = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dg_checkartikel = new System.Windows.Forms.DataGridView();
            this.rtb_bem = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_versandkosten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lieferscheine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bestellungen)).BeginInit();
            this.gb_lsdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lsartikel)).BeginInit();
            this.gb_checkartikel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_checkartikel)).BeginInit();
            this.SuspendLayout();
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(1109, 643);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 27;
            this.b_back.Text = "zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // dg_lieferscheine
            // 
            this.dg_lieferscheine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_lieferscheine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lieferscheine.Location = new System.Drawing.Point(22, 93);
            this.dg_lieferscheine.MultiSelect = false;
            this.dg_lieferscheine.Name = "dg_lieferscheine";
            this.dg_lieferscheine.ReadOnly = true;
            this.dg_lieferscheine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_lieferscheine.Size = new System.Drawing.Size(548, 175);
            this.dg_lieferscheine.TabIndex = 28;
            this.dg_lieferscheine.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lieferscheine_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Lieferungen";
            // 
            // dg_bestellungen
            // 
            this.dg_bestellungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_bestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bestellungen.Location = new System.Drawing.Point(651, 93);
            this.dg_bestellungen.MultiSelect = false;
            this.dg_bestellungen.Name = "dg_bestellungen";
            this.dg_bestellungen.ReadOnly = true;
            this.dg_bestellungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_bestellungen.Size = new System.Drawing.Size(528, 175);
            this.dg_bestellungen.TabIndex = 30;
            this.dg_bestellungen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bestellungen_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Erwartete Bestellungen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lieferscheine";
            // 
            // gb_lsdetails
            // 
            this.gb_lsdetails.Controls.Add(this.label4);
            this.gb_lsdetails.Controls.Add(this.dg_lsartikel);
            this.gb_lsdetails.Location = new System.Drawing.Point(22, 287);
            this.gb_lsdetails.Name = "gb_lsdetails";
            this.gb_lsdetails.Size = new System.Drawing.Size(548, 350);
            this.gb_lsdetails.TabIndex = 33;
            this.gb_lsdetails.TabStop = false;
            this.gb_lsdetails.Text = "Lieferschein Details";
            this.gb_lsdetails.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "enthaltene Artikel";
            // 
            // dg_lsartikel
            // 
            this.dg_lsartikel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_lsartikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lsartikel.Location = new System.Drawing.Point(0, 118);
            this.dg_lsartikel.MultiSelect = false;
            this.dg_lsartikel.Name = "dg_lsartikel";
            this.dg_lsartikel.Size = new System.Drawing.Size(548, 179);
            this.dg_lsartikel.TabIndex = 0;
            // 
            // gb_checkartikel
            // 
            this.gb_checkartikel.Controls.Add(this.label7);
            this.gb_checkartikel.Controls.Add(this.tb_versandkosten);
            this.gb_checkartikel.Controls.Add(this.label6);
            this.gb_checkartikel.Controls.Add(this.rtb_bem);
            this.gb_checkartikel.Controls.Add(this.b_edit_anzahl);
            this.gb_checkartikel.Controls.Add(this.b_delete_artikel);
            this.gb_checkartikel.Controls.Add(this.b_newls);
            this.gb_checkartikel.Controls.Add(this.label5);
            this.gb_checkartikel.Controls.Add(this.dg_checkartikel);
            this.gb_checkartikel.Location = new System.Drawing.Point(651, 287);
            this.gb_checkartikel.Name = "gb_checkartikel";
            this.gb_checkartikel.Size = new System.Drawing.Size(528, 350);
            this.gb_checkartikel.TabIndex = 34;
            this.gb_checkartikel.TabStop = false;
            this.gb_checkartikel.Text = "Lieferschein erstellen";
            this.gb_checkartikel.Visible = false;
            // 
            // b_edit_anzahl
            // 
            this.b_edit_anzahl.Location = new System.Drawing.Point(222, 239);
            this.b_edit_anzahl.Name = "b_edit_anzahl";
            this.b_edit_anzahl.Size = new System.Drawing.Size(111, 23);
            this.b_edit_anzahl.TabIndex = 38;
            this.b_edit_anzahl.Text = "Menge anpassen";
            this.b_edit_anzahl.UseVisualStyleBackColor = true;
            this.b_edit_anzahl.Visible = false;
            this.b_edit_anzahl.Click += new System.EventHandler(this.b_edit_anzahl_Click);
            // 
            // b_delete_artikel
            // 
            this.b_delete_artikel.ForeColor = System.Drawing.Color.Red;
            this.b_delete_artikel.Location = new System.Drawing.Point(387, 239);
            this.b_delete_artikel.Name = "b_delete_artikel";
            this.b_delete_artikel.Size = new System.Drawing.Size(135, 23);
            this.b_delete_artikel.TabIndex = 37;
            this.b_delete_artikel.Text = "Artikel entfernen";
            this.b_delete_artikel.UseVisualStyleBackColor = true;
            this.b_delete_artikel.Visible = false;
            this.b_delete_artikel.Click += new System.EventHandler(this.b_delete_artikel_Click);
            // 
            // b_newls
            // 
            this.b_newls.ForeColor = System.Drawing.Color.Green;
            this.b_newls.Location = new System.Drawing.Point(387, 321);
            this.b_newls.Name = "b_newls";
            this.b_newls.Size = new System.Drawing.Size(135, 23);
            this.b_newls.TabIndex = 36;
            this.b_newls.Text = "Lieferung erhalten";
            this.b_newls.UseVisualStyleBackColor = true;
            this.b_newls.Click += new System.EventHandler(this.b_newls_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Artikel überprüfen";
            // 
            // dg_checkartikel
            // 
            this.dg_checkartikel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_checkartikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_checkartikel.Location = new System.Drawing.Point(1, 54);
            this.dg_checkartikel.MultiSelect = false;
            this.dg_checkartikel.Name = "dg_checkartikel";
            this.dg_checkartikel.ReadOnly = true;
            this.dg_checkartikel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_checkartikel.Size = new System.Drawing.Size(527, 179);
            this.dg_checkartikel.TabIndex = 34;
            this.dg_checkartikel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_checkartikel_RowEnter);
            // 
            // rtb_bem
            // 
            this.rtb_bem.Location = new System.Drawing.Point(1, 264);
            this.rtb_bem.Name = "rtb_bem";
            this.rtb_bem.Size = new System.Drawing.Size(153, 80);
            this.rtb_bem.TabIndex = 39;
            this.rtb_bem.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Bemerkung";
            // 
            // tb_versandkosten
            // 
            this.tb_versandkosten.Location = new System.Drawing.Point(160, 321);
            this.tb_versandkosten.Name = "tb_versandkosten";
            this.tb_versandkosten.Size = new System.Drawing.Size(100, 20);
            this.tb_versandkosten.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Versandkosten:";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 669);
            this.Controls.Add(this.gb_checkartikel);
            this.Controls.Add(this.gb_lsdetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_bestellungen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_lieferscheine);
            this.Controls.Add(this.b_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form9";
            this.Text = "Lieferungen";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_lieferscheine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bestellungen)).EndInit();
            this.gb_lsdetails.ResumeLayout(false);
            this.gb_lsdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lsartikel)).EndInit();
            this.gb_checkartikel.ResumeLayout(false);
            this.gb_checkartikel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_checkartikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.DataGridView dg_lieferscheine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_bestellungen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_lsdetails;
        private System.Windows.Forms.GroupBox gb_checkartikel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_lsartikel;
        private System.Windows.Forms.Button b_newls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dg_checkartikel;
        private System.Windows.Forms.Button b_delete_artikel;
        private System.Windows.Forms.Button b_edit_anzahl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_bem;
        private System.Windows.Forms.TextBox tb_versandkosten;
        private System.Windows.Forms.Label label7;
    }
}