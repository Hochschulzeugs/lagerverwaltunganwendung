namespace lagerverwaltunganwendung
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_save = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_filter = new System.Windows.Forms.Button();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_lagerort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_aname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_lagerortdg = new System.Windows.Forms.ComboBox();
            this.cb_einheitdg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Artikelübersicht";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(579, 250);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // b_save
            // 
            this.b_save.ForeColor = System.Drawing.Color.Green;
            this.b_save.Location = new System.Drawing.Point(329, 406);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(109, 23);
            this.b_save.TabIndex = 10;
            this.b_save.Text = "Ansicht speichern";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(689, 406);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 12;
            this.b_back.Text = "zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // b_delete
            // 
            this.b_delete.ForeColor = System.Drawing.Color.Red;
            this.b_delete.Location = new System.Drawing.Point(122, 406);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(109, 23);
            this.b_delete.TabIndex = 19;
            this.b_delete.Text = "Auswahl löschen";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_filter
            // 
            this.b_filter.Location = new System.Drawing.Point(15, 46);
            this.b_filter.Name = "b_filter";
            this.b_filter.Size = new System.Drawing.Size(95, 23);
            this.b_filter.TabIndex = 21;
            this.b_filter.Text = "Filter anzeigen";
            this.b_filter.UseVisualStyleBackColor = true;
            this.b_filter.Click += new System.EventHandler(this.b_filter_Click);
            // 
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.label2);
            this.gb_filter.Controls.Add(this.cb_lagerort);
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.tb_aname);
            this.gb_filter.Location = new System.Drawing.Point(12, 75);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(579, 60);
            this.gb_filter.TabIndex = 20;
            this.gb_filter.TabStop = false;
            this.gb_filter.Text = "Filter";
            this.gb_filter.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lagerort";
            // 
            // cb_lagerort
            // 
            this.cb_lagerort.FormattingEnabled = true;
            this.cb_lagerort.Location = new System.Drawing.Point(176, 33);
            this.cb_lagerort.Name = "cb_lagerort";
            this.cb_lagerort.Size = new System.Drawing.Size(121, 21);
            this.cb_lagerort.TabIndex = 14;
            this.cb_lagerort.SelectedIndexChanged += new System.EventHandler(this.cb_lagerort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Artikelname";
            // 
            // tb_aname
            // 
            this.tb_aname.Location = new System.Drawing.Point(3, 35);
            this.tb_aname.Name = "tb_aname";
            this.tb_aname.Size = new System.Drawing.Size(148, 20);
            this.tb_aname.TabIndex = 12;
            this.tb_aname.TextChanged += new System.EventHandler(this.tb_aname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lagerort (ID, Name)";
            // 
            // cb_lagerortdg
            // 
            this.cb_lagerortdg.FormattingEnabled = true;
            this.cb_lagerortdg.Location = new System.Drawing.Point(626, 141);
            this.cb_lagerortdg.Name = "cb_lagerortdg";
            this.cb_lagerortdg.Size = new System.Drawing.Size(111, 21);
            this.cb_lagerortdg.TabIndex = 24;
            this.cb_lagerortdg.SelectedIndexChanged += new System.EventHandler(this.cb_lagerortdg_SelectedIndexChanged);
            // 
            // cb_einheitdg
            // 
            this.cb_einheitdg.FormattingEnabled = true;
            this.cb_einheitdg.Location = new System.Drawing.Point(626, 204);
            this.cb_einheitdg.Name = "cb_einheitdg";
            this.cb_einheitdg.Size = new System.Drawing.Size(111, 21);
            this.cb_einheitdg.TabIndex = 27;
            this.cb_einheitdg.SelectedIndexChanged += new System.EventHandler(this.cb_einheitdg_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Einheit (ID, Name)";
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(12, 397);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 28;
            this.b_refresh.Text = "aktualisieren";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 441);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.cb_einheitdg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_lagerortdg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_filter);
            this.Controls.Add(this.gb_filter);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_filter;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_lagerort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_aname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_lagerortdg;
        private System.Windows.Forms.ComboBox cb_einheitdg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_refresh;
    }
}