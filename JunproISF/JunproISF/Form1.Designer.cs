namespace JunproISF
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(59, 213);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(456, 195);
            this.dgv.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(59, 169);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(246, 169);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dep. Karyawan  :";
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(180, 124);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(142, 21);
            this.cbDep.TabIndex = 7;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(180, 90);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(142, 20);
            this.tbNama.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(428, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 78);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Departemen\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Fi" +
    "nance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(62, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(36, 36);
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Karyawan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PT Respons Ijaya";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

