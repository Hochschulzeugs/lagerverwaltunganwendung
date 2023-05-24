namespace lagerverwaltunganwendung
{
    partial class Form8
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
            this.b_refresh = new System.Windows.Forms.Button();
            this.b_delete_order = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gb_bestell_details = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_bem = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_add = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_new_kosten = new System.Windows.Forms.TextBox();
            this.label_new_einheit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_new_anzahl = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_new_artikel = new System.Windows.Forms.ComboBox();
            this.gb_edit_artikel = new System.Windows.Forms.GroupBox();
            this.b_edit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_edit_kosten = new System.Windows.Forms.TextBox();
            this.label_edit_einheit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_edit_anzahl = new System.Windows.Forms.TextBox();
            this.b_save_orderstatus = new System.Windows.Forms.Button();
            this.b_delete_artikel = new System.Windows.Forms.Button();
            this.cb_sachbearbeiter = new System.Windows.Forms.ComboBox();
            this.cb_lieferant = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_add_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_bestell_details.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_edit_artikel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bestellungen";
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(12, 537);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(82, 23);
            this.b_refresh.TabIndex = 29;
            this.b_refresh.Text = "zurücksetzen";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // b_delete_order
            // 
            this.b_delete_order.ForeColor = System.Drawing.Color.Red;
            this.b_delete_order.Location = new System.Drawing.Point(226, 193);
            this.b_delete_order.Name = "b_delete_order";
            this.b_delete_order.Size = new System.Drawing.Size(135, 23);
            this.b_delete_order.TabIndex = 28;
            this.b_delete_order.Text = "Bestellung löschen";
            this.b_delete_order.UseVisualStyleBackColor = true;
            this.b_delete_order.Click += new System.EventHandler(this.b_delete_order_Click);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(833, 537);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 26;
            this.b_back.Text = "zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(896, 125);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
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
            this.dataGridView2.Size = new System.Drawing.Size(376, 241);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // gb_bestell_details
            // 
            this.gb_bestell_details.Controls.Add(this.label7);
            this.gb_bestell_details.Controls.Add(this.rtb_bem);
            this.gb_bestell_details.Controls.Add(this.groupBox3);
            this.gb_bestell_details.Controls.Add(this.gb_edit_artikel);
            this.gb_bestell_details.Controls.Add(this.b_save_orderstatus);
            this.gb_bestell_details.Controls.Add(this.b_delete_artikel);
            this.gb_bestell_details.Controls.Add(this.cb_sachbearbeiter);
            this.gb_bestell_details.Controls.Add(this.cb_lieferant);
            this.gb_bestell_details.Controls.Add(this.cb_status);
            this.gb_bestell_details.Controls.Add(this.label5);
            this.gb_bestell_details.Controls.Add(this.label4);
            this.gb_bestell_details.Controls.Add(this.label2);
            this.gb_bestell_details.Controls.Add(this.label1);
            this.gb_bestell_details.Controls.Add(this.dataGridView2);
            this.gb_bestell_details.Location = new System.Drawing.Point(12, 218);
            this.gb_bestell_details.Name = "gb_bestell_details";
            this.gb_bestell_details.Size = new System.Drawing.Size(896, 303);
            this.gb_bestell_details.TabIndex = 31;
            this.gb_bestell_details.TabStop = false;
            this.gb_bestell_details.Text = "Bestell-Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Bemerkung:";
            // 
            // rtb_bem
            // 
            this.rtb_bem.Location = new System.Drawing.Point(629, 107);
            this.rtb_bem.Name = "rtb_bem";
            this.rtb_bem.Size = new System.Drawing.Size(254, 103);
            this.rtb_bem.TabIndex = 48;
            this.rtb_bem.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_add);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tb_new_kosten);
            this.groupBox3.Controls.Add(this.label_new_einheit);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tb_new_anzahl);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cb_new_artikel);
            this.groupBox3.Location = new System.Drawing.Point(401, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 140);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neuen Artikel hinzufügen";
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.Location = new System.Drawing.Point(71, 111);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(67, 22);
            this.b_add.TabIndex = 52;
            this.b_add.Text = "hinzufügen";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_new_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Kosten:";
            // 
            // tb_new_kosten
            // 
            this.tb_new_kosten.Location = new System.Drawing.Point(51, 85);
            this.tb_new_kosten.Name = "tb_new_kosten";
            this.tb_new_kosten.ReadOnly = true;
            this.tb_new_kosten.Size = new System.Drawing.Size(100, 20);
            this.tb_new_kosten.TabIndex = 49;
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
            this.tb_new_anzahl.TextChanged += new System.EventHandler(this.tb_new_anzahl_TextChanged);
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
            // gb_edit_artikel
            // 
            this.gb_edit_artikel.Controls.Add(this.b_edit);
            this.gb_edit_artikel.Controls.Add(this.label10);
            this.gb_edit_artikel.Controls.Add(this.label9);
            this.gb_edit_artikel.Controls.Add(this.tb_edit_kosten);
            this.gb_edit_artikel.Controls.Add(this.label_edit_einheit);
            this.gb_edit_artikel.Controls.Add(this.label8);
            this.gb_edit_artikel.Controls.Add(this.tb_edit_anzahl);
            this.gb_edit_artikel.Location = new System.Drawing.Point(401, 161);
            this.gb_edit_artikel.Name = "gb_edit_artikel";
            this.gb_edit_artikel.Size = new System.Drawing.Size(222, 140);
            this.gb_edit_artikel.TabIndex = 46;
            this.gb_edit_artikel.TabStop = false;
            this.gb_edit_artikel.Text = "ausgewählten Artikel bearbeiten";
            this.gb_edit_artikel.Visible = false;
            // 
            // b_edit
            // 
            this.b_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_edit.Location = new System.Drawing.Point(68, 89);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(67, 22);
            this.b_edit.TabIndex = 53;
            this.b_edit.Text = "speichern";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Kosten:";
            // 
            // tb_edit_kosten
            // 
            this.tb_edit_kosten.Location = new System.Drawing.Point(48, 63);
            this.tb_edit_kosten.Name = "tb_edit_kosten";
            this.tb_edit_kosten.ReadOnly = true;
            this.tb_edit_kosten.Size = new System.Drawing.Size(100, 20);
            this.tb_edit_kosten.TabIndex = 49;
            // 
            // label_edit_einheit
            // 
            this.label_edit_einheit.AutoSize = true;
            this.label_edit_einheit.Location = new System.Drawing.Point(154, 36);
            this.label_edit_einheit.Name = "label_edit_einheit";
            this.label_edit_einheit.Size = new System.Drawing.Size(44, 13);
            this.label_edit_einheit.TabIndex = 48;
            this.label_edit_einheit.Text = "-einheit-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Anzahl:";
            // 
            // tb_edit_anzahl
            // 
            this.tb_edit_anzahl.Location = new System.Drawing.Point(48, 33);
            this.tb_edit_anzahl.Name = "tb_edit_anzahl";
            this.tb_edit_anzahl.Size = new System.Drawing.Size(100, 20);
            this.tb_edit_anzahl.TabIndex = 46;
            this.tb_edit_anzahl.TextChanged += new System.EventHandler(this.tb_edit_anzahl_TextChanged);
            // 
            // b_save_orderstatus
            // 
            this.b_save_orderstatus.ForeColor = System.Drawing.Color.Green;
            this.b_save_orderstatus.Location = new System.Drawing.Point(772, 224);
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
            this.cb_sachbearbeiter.Location = new System.Drawing.Point(743, 65);
            this.cb_sachbearbeiter.Name = "cb_sachbearbeiter";
            this.cb_sachbearbeiter.Size = new System.Drawing.Size(140, 21);
            this.cb_sachbearbeiter.TabIndex = 40;
            // 
            // cb_lieferant
            // 
            this.cb_lieferant.FormattingEnabled = true;
            this.cb_lieferant.Location = new System.Drawing.Point(743, 39);
            this.cb_lieferant.Name = "cb_lieferant";
            this.cb_lieferant.Size = new System.Drawing.Size(140, 21);
            this.cb_lieferant.TabIndex = 39;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(743, 12);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(140, 21);
            this.cb_status.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sachbearbeiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Lieferant:";
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
            // b_add_order
            // 
            this.b_add_order.ForeColor = System.Drawing.Color.Green;
            this.b_add_order.Location = new System.Drawing.Point(533, 193);
            this.b_add_order.Name = "b_add_order";
            this.b_add_order.Size = new System.Drawing.Size(132, 23);
            this.b_add_order.TabIndex = 36;
            this.b_add_order.Text = "Bestellung hinzufügen";
            this.b_add_order.UseVisualStyleBackColor = true;
            this.b_add_order.Click += new System.EventHandler(this.b_add_order_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 572);
            this.Controls.Add(this.b_add_order);
            this.Controls.Add(this.gb_bestell_details);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.b_delete_order);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellungen";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_bestell_details.ResumeLayout(false);
            this.gb_bestell_details.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_edit_artikel.ResumeLayout(false);
            this.gb_edit_artikel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Button b_delete_order;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gb_bestell_details;
        private System.Windows.Forms.ComboBox cb_sachbearbeiter;
        private System.Windows.Forms.ComboBox cb_lieferant;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_delete_artikel;
        private System.Windows.Forms.Button b_save_orderstatus;
        private System.Windows.Forms.GroupBox gb_edit_artikel;
        private System.Windows.Forms.Label label_edit_einheit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_edit_anzahl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_edit_kosten;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_new_kosten;
        private System.Windows.Forms.Label label_new_einheit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_new_anzahl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_new_artikel;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_add_order;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_bem;
    }
}