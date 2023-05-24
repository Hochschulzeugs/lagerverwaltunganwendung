namespace lagerverwaltunganwendung
{
    partial class Form7
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
            this.b_back = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lieferanten";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1289, 350);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(1244, 445);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 10;
            this.b_back.Text = "zurück";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // b_delete
            // 
            this.b_delete.ForeColor = System.Drawing.Color.Red;
            this.b_delete.Location = new System.Drawing.Point(519, 445);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(111, 23);
            this.b_delete.TabIndex = 23;
            this.b_delete.Text = "Auswahl löschen";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_save
            // 
            this.b_save.ForeColor = System.Drawing.Color.Green;
            this.b_save.Location = new System.Drawing.Point(659, 445);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(111, 23);
            this.b_save.TabIndex = 22;
            this.b_save.Text = "Ansicht speichern";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(30, 445);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(75, 23);
            this.b_refresh.TabIndex = 24;
            this.b_refresh.Text = "aktualisieren";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 501);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lieferanten";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_refresh;
    }
}