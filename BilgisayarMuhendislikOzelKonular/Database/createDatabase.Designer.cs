namespace BilgisayarMuhendislikOzelKonular.Database
{
    partial class createDatabase
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
            this.L_databaseName = new System.Windows.Forms.Label();
            this.TXT_databaseName = new System.Windows.Forms.TextBox();
            this.B_createDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veritabanı Oluştur";
            // 
            // L_databaseName
            // 
            this.L_databaseName.AutoSize = true;
            this.L_databaseName.Location = new System.Drawing.Point(12, 114);
            this.L_databaseName.Name = "L_databaseName";
            this.L_databaseName.Size = new System.Drawing.Size(81, 13);
            this.L_databaseName.TabIndex = 1;
            this.L_databaseName.Text = "Veritabanı Adı : ";
            // 
            // TXT_databaseName
            // 
            this.TXT_databaseName.Location = new System.Drawing.Point(99, 111);
            this.TXT_databaseName.Name = "TXT_databaseName";
            this.TXT_databaseName.Size = new System.Drawing.Size(100, 20);
            this.TXT_databaseName.TabIndex = 2;
            // 
            // B_createDatabase
            // 
            this.B_createDatabase.Location = new System.Drawing.Point(216, 109);
            this.B_createDatabase.Name = "B_createDatabase";
            this.B_createDatabase.Size = new System.Drawing.Size(109, 23);
            this.B_createDatabase.TabIndex = 3;
            this.B_createDatabase.Text = "Veritabanı Oluştur";
            this.B_createDatabase.UseVisualStyleBackColor = true;
            this.B_createDatabase.Click += new System.EventHandler(this.B_createDatabase_Click);
            // 
            // createDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 163);
            this.Controls.Add(this.B_createDatabase);
            this.Controls.Add(this.TXT_databaseName);
            this.Controls.Add(this.L_databaseName);
            this.Controls.Add(this.label1);
            this.Name = "createDatabase";
            this.Text = "createDatabase";
            this.Load += new System.EventHandler(this.createDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_databaseName;
        private System.Windows.Forms.TextBox TXT_databaseName;
        private System.Windows.Forms.Button B_createDatabase;
    }
}