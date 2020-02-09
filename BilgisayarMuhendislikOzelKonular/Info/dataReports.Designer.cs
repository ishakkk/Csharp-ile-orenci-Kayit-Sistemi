namespace BilgisayarMuhendislikOzelKonular.Info
{
    partial class dataReports
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
            this.TB_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_average = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_fileName
            // 
            this.TB_fileName.Location = new System.Drawing.Point(12, 35);
            this.TB_fileName.Name = "TB_fileName";
            this.TB_fileName.Size = new System.Drawing.Size(206, 20);
            this.TB_fileName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dosya İsmi : ";
            // 
            // B_average
            // 
            this.B_average.Location = new System.Drawing.Point(12, 61);
            this.B_average.Name = "B_average";
            this.B_average.Size = new System.Drawing.Size(206, 51);
            this.B_average.TabIndex = 4;
            this.B_average.Text = "BM100 Öğrenciler Ve Not Ortalaması";
            this.B_average.UseVisualStyleBackColor = true;
            this.B_average.Click += new System.EventHandler(this.B_average_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "BM200 Öğrenciler Ve Not Ortalaması";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "BM300 Öğrenciler Ve Not Ortalaması";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_fileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_average);
            this.Name = "DataReports";
            this.Text = "Veri Raporlarını Belgelendir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_average;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}