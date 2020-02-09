namespace BilgisayarMuhendislikOzelKonular.Info
{
    partial class deleteDatas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableRows = new System.Windows.Forms.DataGridView();
            this.deleteTableRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableRows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listelenecek Olan Tabloyu Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Öğrenciler",
            "Dersler",
            "Ders Notları"});
            this.comboBox1.Location = new System.Drawing.Point(12, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableRows
            // 
            this.tableRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableRows.Location = new System.Drawing.Point(12, 91);
            this.tableRows.Name = "tableRows";
            this.tableRows.Size = new System.Drawing.Size(644, 355);
            this.tableRows.TabIndex = 3;
            this.tableRows.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableRows_CellClick);
            // 
            // deleteTableRow
            // 
            this.deleteTableRow.Location = new System.Drawing.Point(12, 452);
            this.deleteTableRow.Name = "deleteTableRow";
            this.deleteTableRow.Size = new System.Drawing.Size(121, 33);
            this.deleteTableRow.TabIndex = 6;
            this.deleteTableRow.Text = "Sil";
            this.deleteTableRow.UseVisualStyleBackColor = true;
            this.deleteTableRow.Click += new System.EventHandler(this.deleteTableRow_Click);
            // 
            // deleteDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 517);
            this.Controls.Add(this.deleteTableRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableRows);
            this.Name = "deleteDatas";
            this.Text = "Kayıt Sil";
            this.Load += new System.EventHandler(this.deleteDatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView tableRows;
        private System.Windows.Forms.Button deleteTableRow;
    }
}