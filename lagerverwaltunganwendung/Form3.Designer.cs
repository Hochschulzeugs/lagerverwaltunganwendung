namespace lagerverwaltunganwendung
{
    partial class Form3
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
            this.dg_user = new System.Windows.Forms.DataGridView();
            this.b_savedg = new System.Windows.Forms.Button();
            this.tb_oldpw = new System.Windows.Forms.TextBox();
            this.tb_newpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_newpw2 = new System.Windows.Forms.TextBox();
            this.b_changepw = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Benutzereinstellungen";
            // 
            // dg_user
            // 
            this.dg_user.AllowUserToAddRows = false;
            this.dg_user.AllowUserToDeleteRows = false;
            this.dg_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_user.Location = new System.Drawing.Point(15, 78);
            this.dg_user.Name = "dg_user";
            this.dg_user.Size = new System.Drawing.Size(733, 79);
            this.dg_user.TabIndex = 7;
            // 
            // b_savedg
            // 
            this.b_savedg.Location = new System.Drawing.Point(673, 163);
            this.b_savedg.Name = "b_savedg";
            this.b_savedg.Size = new System.Drawing.Size(75, 23);
            this.b_savedg.TabIndex = 8;
            this.b_savedg.Text = "speichern";
            this.b_savedg.UseVisualStyleBackColor = true;
            this.b_savedg.Click += new System.EventHandler(this.b_savedg_Click);
            // 
            // tb_oldpw
            // 
            this.tb_oldpw.Location = new System.Drawing.Point(154, 187);
            this.tb_oldpw.Name = "tb_oldpw";
            this.tb_oldpw.PasswordChar = '*';
            this.tb_oldpw.Size = new System.Drawing.Size(139, 20);
            this.tb_oldpw.TabIndex = 9;
            // 
            // tb_newpw
            // 
            this.tb_newpw.Location = new System.Drawing.Point(154, 228);
            this.tb_newpw.Name = "tb_newpw";
            this.tb_newpw.PasswordChar = '*';
            this.tb_newpw.Size = new System.Drawing.Size(139, 20);
            this.tb_newpw.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Altes Passwort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Neues Passwort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Neues Passwort bestätigen";
            // 
            // tb_newpw2
            // 
            this.tb_newpw2.Location = new System.Drawing.Point(154, 266);
            this.tb_newpw2.Name = "tb_newpw2";
            this.tb_newpw2.PasswordChar = '*';
            this.tb_newpw2.Size = new System.Drawing.Size(139, 20);
            this.tb_newpw2.TabIndex = 13;
            // 
            // b_changepw
            // 
            this.b_changepw.Location = new System.Drawing.Point(308, 261);
            this.b_changepw.Name = "b_changepw";
            this.b_changepw.Size = new System.Drawing.Size(104, 23);
            this.b_changepw.TabIndex = 15;
            this.b_changepw.Text = "Passwort ändern";
            this.b_changepw.UseVisualStyleBackColor = true;
            this.b_changepw.Click += new System.EventHandler(this.b_changepw_Click);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(673, 256);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 16;
            this.b_back.Text = "Zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 316);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_changepw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_newpw2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_newpw);
            this.Controls.Add(this.tb_oldpw);
            this.Controls.Add(this.b_savedg);
            this.Controls.Add(this.dg_user);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzereinstellungen";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_user;
        private System.Windows.Forms.Button b_savedg;
        private System.Windows.Forms.TextBox tb_oldpw;
        private System.Windows.Forms.TextBox tb_newpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_newpw2;
        private System.Windows.Forms.Button b_changepw;
        private System.Windows.Forms.Button b_back;
    }
}