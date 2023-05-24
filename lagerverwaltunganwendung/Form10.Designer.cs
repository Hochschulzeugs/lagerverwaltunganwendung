namespace lagerverwaltunganwendung
{
    partial class Form10
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
            this.b_add_order = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_mat_details = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_bem = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_add = new System.Windows.Forms.Button();
            this.label_new_einheit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_new_anzahl = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_new_artikel = new System.Windows.Forms.ComboBox();
            this.b_save_orderstatus = new System.Windows.Forms.Button();
            this.b_delete_artikel = new System.Windows.Forms.Button();
            this.cb_sachbearbeiter = new System.Windows.Forms.ComboBox();
            this.cb_empf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_mat_details.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_add_order
            // 
            this.b_add_order.ForeColor = System.Drawing.Color.Green;
            this.b_add_order.Location = new System.Drawing.Point(584, 191);
            this.b_add_order.Name = "b_add_order";
            this.b_add_order.Size = new System.Drawing.Size(132, 23);
            this.b_add_order.TabIndex = 40;
            this.b_add_order.Text = "neuer Matschein";
            this.b_add_order.UseVisualStyleBackColor = true;
            this.b_add_order.Click += new System.EventHandler(this.b_add_order_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 125);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Materialentnahme";
            // 
            // gb_mat_details
            // 
            this.gb_mat_details.Controls.Add(this.label7);
            this.gb_mat_details.Controls.Add(this.rtb_bem);
            this.gb_mat_details.Controls.Add(this.groupBox3);
            this.gb_mat_details.Controls.Add(this.b_save_orderstatus);
            this.gb_mat_details.Controls.Add(this.b_delete_artikel);
            this.gb_mat_details.Controls.Add(this.cb_sachbearbeiter);
            this.gb_mat_details.Controls.Add(this.cb_empf);
            this.gb_mat_details.Controls.Add(this.label4);
            this.gb_mat_details.Controls.Add(this.label2);
            this.gb_mat_details.Controls.Add(this.label1);
            this.gb_mat_details.Controls.Add(this.dataGridView2);
            this.gb_mat_details.Location = new System.Drawing.Point(12, 248);
            this.gb_mat_details.Name = "gb_mat_details";
            this.gb_mat_details.Size = new System.Drawing.Size(756, 303);
            this.gb_mat_details.TabIndex = 41;
            this.gb_mat_details.TabStop = false;
            this.gb_mat_details.Text = "Materialschein-Details";
            this.gb_mat_details.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Bemerkung:";
            // 
            // rtb_bem
            // 
            this.rtb_bem.Location = new System.Drawing.Point(500, 96);
            this.rtb_bem.Name = "rtb_bem";
            this.rtb_bem.Size = new System.Drawing.Size(254, 103);
            this.rtb_bem.TabIndex = 48;
            this.rtb_bem.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_add);
            this.groupBox3.Controls.Add(this.label_new_einheit);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tb_new_anzahl);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cb_new_artikel);
            this.groupBox3.Location = new System.Drawing.Point(269, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 114);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neuen Artikel hinzufügen";
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.Location = new System.Drawing.Point(68, 81);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(67, 22);
            this.b_add.TabIndex = 52;
            this.b_add.Text = "hinzufügen";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // label_new_einheit
            // 
            this.label_new_einheit.AutoSize = true;
            this.label_new_einheit.Location = new System.Drawing.Point(157, 58);
            this.label_new_einheit.Name = "label_new_einheit";
            this.label_new_einheit.Size = new System.Drawing.Size(44, 13);
            this.label_new_einheit.TabIndex = 48;
            this.label_new_einheit.Text = "-einheit-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Anzahl:";
            // 
            // tb_new_anzahl
            // 
            this.tb_new_anzahl.Location = new System.Drawing.Point(51, 55);
            this.tb_new_anzahl.Name = "tb_new_anzahl";
            this.tb_new_anzahl.Size = new System.Drawing.Size(100, 20);
            this.tb_new_anzahl.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Artikel:";
            // 
            // cb_new_artikel
            // 
            this.cb_new_artikel.FormattingEnabled = true;
            this.cb_new_artikel.Location = new System.Drawing.Point(51, 27);
            this.cb_new_artikel.Name = "cb_new_artikel";
            this.cb_new_artikel.Size = new System.Drawing.Size(140, 21);
            this.cb_new_artikel.TabIndex = 45;
            this.cb_new_artikel.SelectedIndexChanged += new System.EventHandler(this.cb_new_artikel_SelectedIndexChanged);
            // 
            // b_save_orderstatus
            // 
            this.b_save_orderstatus.ForeColor = System.Drawing.Color.Green;
            this.b_save_orderstatus.Location = new System.Drawing.Point(572, 203);
            this.b_save_orderstatus.Name = "b_save_orderstatus";
            this.b_save_orderstatus.Size = new System.Drawing.Size(111, 23);
            this.b_save_orderstatus.TabIndex = 42;
            this.b_save_orderstatus.Text = "speichern";
            this.b_save_orderstatus.UseVisualStyleBackColor = true;
            this.b_save_orderstatus.Click += new System.EventHandler(this.b_save_orderstatus_Click);
            // 
            // b_delete_artikel
            // 
            this.b_delete_artikel.ForeColor = System.Drawing.Color.Red;
            this.b_delete_artikel.Location = new System.Drawing.Point(0, 278);
            this.b_delete_artikel.Name = "b_delete_artikel";
            this.b_delete_artikel.Size = new System.Drawing.Size(161, 23);
            this.b_delete_artikel.TabIndex = 41;
            this.b_delete_artikel.Text = "ausgewählten Artikel löschen";
            this.b_delete_artikel.UseVisualStyleBackColor = true;
            this.b_delete_artikel.Click += new System.EventHandler(this.b_delete_artikel_Click);
            // 
            // cb_sachbearbeiter
            // 
            this.cb_sachbearbeiter.FormattingEnabled = true;
            this.cb_sachbearbeiter.Location = new System.Drawing.Point(585, 54);
            this.cb_sachbearbeiter.Name = "cb_sachbearbeiter";
            this.cb_sachbearbeiter.Size = new System.Drawing.Size(140, 21);
            this.cb_sachbearbeiter.TabIndex = 40;
            // 
            // cb_empf
            // 
            this.cb_empf.FormattingEnabled = true;
            this.cb_empf.Location = new System.Drawing.Point(585, 28);
            this.cb_empf.Name = "cb_empf";
            this.cb_empf.Size = new System.Drawing.Size(140, 21);
            this.cb_empf.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sachbearbeiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Empfänger:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Artikel:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 31);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(263, 241);
            this.dataGridView2.TabIndex = 30;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 560);
            this.Controls.Add(this.gb_mat_details);
            this.Controls.Add(this.b_add_order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form10";
            this.Text = "Materialentnahme";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_mat_details.ResumeLayout(false);
            this.gb_mat_details.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_add_order;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_mat_details;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_bem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Label label_new_einheit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_new_anzahl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_new_artikel;
        private System.Windows.Forms.Button b_save_orderstatus;
        private System.Windows.Forms.Button b_delete_artikel;
        private System.Windows.Forms.ComboBox cb_sachbearbeiter;
        private System.Windows.Forms.ComboBox cb_empf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}