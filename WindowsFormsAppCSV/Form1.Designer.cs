
namespace WindowsFormsAppCSV
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
            this.textIme = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.textGod = new System.Windows.Forms.TextBox();
            this.textEm = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(139, 30);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(100, 20);
            this.textIme.TabIndex = 0;
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(139, 85);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(100, 20);
            this.textPrezime.TabIndex = 1;
            // 
            // textGod
            // 
            this.textGod.Location = new System.Drawing.Point(139, 136);
            this.textGod.Name = "textGod";
            this.textGod.Size = new System.Drawing.Size(100, 20);
            this.textGod.TabIndex = 2;
            // 
            // textEm
            // 
            this.textEm.Location = new System.Drawing.Point(139, 190);
            this.textEm.Name = "textEm";
            this.textEm.Size = new System.Drawing.Size(100, 20);
            this.textEm.TabIndex = 3;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(56, 30);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(27, 13);
            this.Ime.TabIndex = 4;
            this.Ime.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "e-mail:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(120, 290);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 8;
            this.btn.Text = "Unesi";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 385);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.textEm);
            this.Controls.Add(this.textGod);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.TextBox textGod;
        private System.Windows.Forms.TextBox textEm;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn;
    }
}

