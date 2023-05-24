namespace lagerverwaltunganwendung
{
    partial class Form6
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
            this.cb_abt = new System.Windows.Forms.ComboBox();
            this.b_back = new System.Windows.Forms.Button();
            this.b_filter = new System.Windows.Forms.Button();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_filterabteilung = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_filteruser = new System.Windows.Forms.TextBox();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.b_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mitarbeiter";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // cb_abt
            // 
            this.cb_abt.FormattingEnabled = true;
            this.cb_abt.Location = new System.Drawing.Point(528, 195);
            this.cb_abt.Name = "cb_abt";
            this.cb_abt.Size = new System.Drawing.Size(121, 21);
            this.cb_abt.TabIndex = 9;
            this.cb_abt.SelectedIndexChanged += new System.EventHandler(this.cb_abt_SelectedIndexChanged);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(427, 294);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 17;
            this.b_back.Text = "Zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // b_filter
            // 
            this.b_filter.Location = new System.Drawing.Point(15, 28);
            this.b_filter.Name = "b_filter";
            this.b_filter.Size = new System.Drawing.Size(95, 23);
            this.b_filter.TabIndex = 19;
            this.b_filter.Text = "Filter anzeigen";
            this.b_filter.UseVisualStyleBackColor = true;
            this.b_filter.Click += new System.EventHandler(this.b_filter_Click);
            // 
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.label2);
            this.gb_filter.Controls.Add(this.cb_filterabteilung);
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.tb_filteruser);
            this.gb_filter.Location = new System.Drawing.Point(12, 57);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(490, 60);
            this.gb_filter.TabIndex = 18;
            this.gb_filter.TabStop = false;
            this.gb_filter.Text = "Filter";
            this.gb_filter.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Abteilung";
            // 
            // cb_filterabteilung
            // 
            this.cb_filterabteilung.FormattingEnabled = true;
            this.cb_filterabteilung.Location = new System.Drawing.Point(176, 33);
            this.cb_filterabteilung.Name = "cb_filterabteilung";
            this.cb_filterabteilung.Size = new System.Drawing.Size(121, 21);
            this.cb_filterabteilung.TabIndex = 14;
            this.cb_filterabteilung.SelectedIndexChanged += new System.EventHandler(this.cb_filterabteilung_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Benutzer";
            // 
            // tb_filteruser
            // 
            this.tb_filteruser.Location = new System.Drawing.Point(3, 35);
            this.tb_filteruser.Name = "tb_filteruser";
            this.tb_filteruser.Size = new System.Drawing.Size(148, 20);
            this.tb_filteruser.TabIndex = 12;
            this.tb_filteruser.TextChanged += new System.EventHandler(this.tb_filteruser_TextChanged);
            // 
            // b_delete
            // 
            this.b_delete.ForeColor = System.Drawing.Color.Red;
            this.b_delete.Location = new System.Drawing.Point(117, 294);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(111, 23);
            this.b_delete.TabIndex = 21;
            this.b_delete.Text = "Auswahl löschen";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_save
            // 
            this.b_save.ForeColor = System.Drawing.Color.Green;
            this.b_save.Location = new System.Drawing.Point(257, 294);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(111, 23);
            this.b_save.TabIndex = 20;
            this.b_save.Text = "Ansicht speichern";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Abteilung (ID, Name)";
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(12, 274);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 23;
            this.b_refresh.Text = "aktualisieren";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 333);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_filter);
            this.Controls.Add(this.gb_filter);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.cb_abt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Mitarbeiter";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_abt;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_filter;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_filterabteilung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_filteruser;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_refresh;
    }
}