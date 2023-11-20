namespace listbox_random_sayi__96
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 16;
            this.lbSayilar.Location = new System.Drawing.Point(23, 71);
            this.lbSayilar.Margin = new System.Windows.Forms.Padding(4);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(201, 340);
            this.lbSayilar.TabIndex = 0;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(23, 30);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(150, 22);
            this.txtSayi.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(180, 30);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(44, 22);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(258, 461);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lbSayilar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnAra;
    }
}

