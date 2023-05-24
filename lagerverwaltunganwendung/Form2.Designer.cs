namespace lagerverwaltunganwendung
{
    partial class Form2
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_admin = new System.Windows.Forms.Button();
            this.b_logout = new System.Windows.Forms.Button();
            this.b_artikel = new System.Windows.Forms.Button();
            this.b_mitarbeiter = new System.Windows.Forms.Button();
            this.b_lieferanten = new System.Windows.Forms.Button();
            this.b_bestellungen = new System.Windows.Forms.Button();
            this.b_lieferungen = new System.Windows.Forms.Button();
            this.b_matentnahme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_artikel_low = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.b_refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_artikel_low)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "DaTi Lagerverwaltung: Hauptmenü";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(315, 50);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(96, 13);
            this.label_welcome.TabIndex = 6;
            this.label_welcome.Text = "WELCOME:NAME";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Einstellungen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(546, 325);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(85, 23);
            this.b_exit.TabIndex = 8;
            this.b_exit.Text = "Beenden";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_admin
            // 
            this.b_admin.Location = new System.Drawing.Point(584, 21);
            this.b_admin.Name = "b_admin";
            this.b_admin.Size = new System.Drawing.Size(85, 23);
            this.b_admin.TabIndex = 9;
            this.b_admin.Text = "Admin";
            this.b_admin.UseVisualStyleBackColor = true;
            this.b_admin.Visible = false;
            this.b_admin.Click += new System.EventHandler(this.b_admin_Click);
            // 
            // b_logout
            // 
            this.b_logout.Location = new System.Drawing.Point(638, 324);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(75, 23);
            this.b_logout.TabIndex = 10;
            this.b_logout.Text = "Ausloggen";
            this.b_logout.UseVisualStyleBackColor = true;
            this.b_logout.Click += new System.EventHandler(this.b_logout_Click);
            // 
            // b_artikel
            // 
            this.b_artikel.Location = new System.Drawing.Point(122, 73);
            this.b_artikel.Name = "b_artikel";
            this.b_artikel.Size = new System.Drawing.Size(105, 23);
            this.b_artikel.TabIndex = 11;
            this.b_artikel.Text = "Artikel";
            this.b_artikel.UseVisualStyleBackColor = true;
            this.b_artikel.Click += new System.EventHandler(this.b_artikel_Click);
            // 
            // b_mitarbeiter
            // 
            this.b_mitarbeiter.Location = new System.Drawing.Point(25, 73);
            this.b_mitarbeiter.Name = "b_mitarbeiter";
            this.b_mitarbeiter.Size = new System.Drawing.Size(91, 23);
            this.b_mitarbeiter.TabIndex = 12;
            this.b_mitarbeiter.Text = "Mitarbeiter";
            this.b_mitarbeiter.UseVisualStyleBackColor = true;
            this.b_mitarbeiter.Click += new System.EventHandler(this.b_mitarbeiter_Click);
            // 
            // b_lieferanten
            // 
            this.b_lieferanten.Location = new System.Drawing.Point(25, 125);
            this.b_lieferanten.Name = "b_lieferanten";
            this.b_lieferanten.Size = new System.Drawing.Size(91, 23);
            this.b_lieferanten.TabIndex = 13;
            this.b_lieferanten.Text = "Lieferanten";
            this.b_lieferanten.UseVisualStyleBackColor = true;
            this.b_lieferanten.Click += new System.EventHandler(this.b_lieferanten_Click);
            // 
            // b_bestellungen
            // 
            this.b_bestellungen.Location = new System.Drawing.Point(122, 125);
            this.b_bestellungen.Name = "b_bestellungen";
            this.b_bestellungen.Size = new System.Drawing.Size(105, 23);
            this.b_bestellungen.TabIndex = 15;
            this.b_bestellungen.Text = "Bestellungen";
            this.b_bestellungen.UseVisualStyleBackColor = true;
            this.b_bestellungen.Click += new System.EventHandler(this.b_bestellungen_Click);
            // 
            // b_lieferungen
            // 
            this.b_lieferungen.Location = new System.Drawing.Point(25, 177);
            this.b_lieferungen.Name = "b_lieferungen";
            this.b_lieferungen.Size = new System.Drawing.Size(91, 23);
            this.b_lieferungen.TabIndex = 16;
            this.b_lieferungen.Text = "Lieferungen";
            this.b_lieferungen.UseVisualStyleBackColor = true;
            this.b_lieferungen.Click += new System.EventHandler(this.b_lieferungen_Click);
            // 
            // b_matentnahme
            // 
            this.b_matentnahme.Location = new System.Drawing.Point(122, 177);
            this.b_matentnahme.Name = "b_matentnahme";
            this.b_matentnahme.Size = new System.Drawing.Size(105, 23);
            this.b_matentnahme.TabIndex = 17;
            this.b_matentnahme.Text = "Materialentnahme";
            this.b_matentnahme.UseVisualStyleBackColor = true;
            this.b_matentnahme.Click += new System.EventHandler(this.b_matentnahme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b_mitarbeiter);
            this.groupBox1.Controls.Add(this.b_matentnahme);
            this.groupBox1.Controls.Add(this.b_artikel);
            this.groupBox1.Controls.Add(this.b_lieferungen);
            this.groupBox1.Controls.Add(this.b_lieferanten);
            this.groupBox1.Controls.Add(this.b_bestellungen);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 206);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Verwaltung";
            // 
            // dg_artikel_low
            // 
            this.dg_artikel_low.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_artikel_low.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_artikel_low.Location = new System.Drawing.Point(279, 148);
            this.dg_artikel_low.Name = "dg_artikel_low";
            this.dg_artikel_low.ReadOnly = true;
            this.dg_artikel_low.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_artikel_low.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_artikel_low.Size = new System.Drawing.Size(434, 159);
            this.dg_artikel_low.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Artikel mit geringen Lagerbestand";
            // 
            // b_refresh
            // 
            this.b_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_refresh.Location = new System.Drawing.Point(638, 121);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 21;
            this.b_refresh.Text = "aktualisieren";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Bestellung notwendig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(393, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "bereits bestellt";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 367);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_artikel_low);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.b_admin);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lagerverwaltung Hauptmenü";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_artikel_low)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_admin;
        private System.Windows.Forms.Button b_logout;
        private System.Windows.Forms.Button b_artikel;
        private System.Windows.Forms.Button b_mitarbeiter;
        private System.Windows.Forms.Button b_lieferanten;
        private System.Windows.Forms.Button b_bestellungen;
        private System.Windows.Forms.Button b_lieferungen;
        private System.Windows.Forms.Button b_matentnahme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_artikel_low;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}