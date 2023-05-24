namespace lagerverwaltunganwendung
{
    partial class Form4
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
            this.b_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_abteilung = new System.Windows.Forms.ComboBox();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_filter = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_userlevel = new System.Windows.Forms.ComboBox();
            this.b_refresh = new System.Windows.Forms.Button();
            this.tb_abt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Administration";
            // 
            // b_save
            // 
            this.b_save.ForeColor = System.Drawing.Color.Green;
            this.b_save.Location = new System.Drawing.Point(323, 357);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(111, 23);
            this.b_save.TabIndex = 8;
            this.b_save.Text = "Ansicht speichern";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
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
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(3, 35);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(148, 20);
            this.tb_user.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 191);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // cb_abteilung
            // 
            this.cb_abteilung.FormattingEnabled = true;
            this.cb_abteilung.Location = new System.Drawing.Point(176, 33);
            this.cb_abteilung.Name = "cb_abteilung";
            this.cb_abteilung.Size = new System.Drawing.Size(121, 21);
            this.cb_abteilung.TabIndex = 14;
            // 
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.label2);
            this.gb_filter.Controls.Add(this.cb_abteilung);
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.tb_user);
            this.gb_filter.Location = new System.Drawing.Point(34, 64);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(684, 60);
            this.gb_filter.TabIndex = 15;
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
            // b_filter
            // 
            this.b_filter.Location = new System.Drawing.Point(37, 35);
            this.b_filter.Name = "b_filter";
            this.b_filter.Size = new System.Drawing.Size(95, 23);
            this.b_filter.TabIndex = 16;
            this.b_filter.Text = "Filter anzeigen";
            this.b_filter.UseVisualStyleBackColor = true;
            this.b_filter.Click += new System.EventHandler(this.b_filter_Click);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(643, 357);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 17;
            this.b_back.Text = "zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // b_delete
            // 
            this.b_delete.ForeColor = System.Drawing.Color.Red;
            this.b_delete.Location = new System.Drawing.Point(183, 357);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(111, 23);
            this.b_delete.TabIndex = 18;
            this.b_delete.Text = "Auswahl löschen";
            this.b_delete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Userlevel";
            // 
            // cb_userlevel
            // 
            this.cb_userlevel.FormattingEnabled = true;
            this.cb_userlevel.Location = new System.Drawing.Point(564, 148);
            this.cb_userlevel.Name = "cb_userlevel";
            this.cb_userlevel.Size = new System.Drawing.Size(121, 21);
            this.cb_userlevel.TabIndex = 19;
            this.cb_userlevel.SelectedIndexChanged += new System.EventHandler(this.cb_userlevel_SelectedIndexChanged);
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(34, 327);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 21;
            this.b_refresh.Text = "aktualisieren";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // tb_abt
            // 
            this.tb_abt.Location = new System.Drawing.Point(564, 245);
            this.tb_abt.Name = "tb_abt";
            this.tb_abt.Size = new System.Drawing.Size(121, 20);
            this.tb_abt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Abteilung";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_abt);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_userlevel);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_filter);
            this.Controls.Add(this.gb_filter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_abteilung;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.Button b_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_userlevel;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.TextBox tb_abt;
        private System.Windows.Forms.Label label5;
    }
}