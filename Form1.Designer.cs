namespace Bai14_SoChinhPhuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnKtra = new System.Windows.Forms.Button();
            this.lsb1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM TRA SỐ CHÍNH PHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(88, 84);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(136, 26);
            this.txtSo.TabIndex = 2;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(53, 129);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(64, 20);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.Text = "Kết quả";
            // 
            // btnKtra
            // 
            this.btnKtra.Location = new System.Drawing.Point(86, 163);
            this.btnKtra.Name = "btnKtra";
            this.btnKtra.Size = new System.Drawing.Size(138, 28);
            this.btnKtra.TabIndex = 4;
            this.btnKtra.Text = "Kiểm tra";
            this.btnKtra.UseVisualStyleBackColor = true;
            this.btnKtra.Click += new System.EventHandler(this.btnKtra_Click);
            // 
            // lsb1
            // 
            this.lsb1.FormattingEnabled = true;
            this.lsb1.ItemHeight = 20;
            this.lsb1.Location = new System.Drawing.Point(416, 84);
            this.lsb1.Name = "lsb1";
            this.lsb1.Size = new System.Drawing.Size(295, 304);
            this.lsb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 574);
            this.Controls.Add(this.lsb1);
            this.Controls.Add(this.btnKtra);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnKtra;
        private System.Windows.Forms.ListBox lsb1;
    }
}

