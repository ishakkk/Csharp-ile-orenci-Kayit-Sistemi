namespace BilgisayarMuhendislikOzelKonular.Info
{
    partial class updateDatas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateStudentGroup = new System.Windows.Forms.GroupBox();
            this.TB_studentNo = new System.Windows.Forms.TextBox();
            this.Label_studentNo = new System.Windows.Forms.Label();
            this.B_updateStudent = new System.Windows.Forms.Button();
            this.TB_birthPlace = new System.Windows.Forms.TextBox();
            this.Label_birthPlace = new System.Windows.Forms.Label();
            this.TB_birthYear = new System.Windows.Forms.TextBox();
            this.Label_birthYear = new System.Windows.Forms.Label();
            this.TB_lastName = new System.Windows.Forms.TextBox();
            this.Label_lastName = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.Label_name = new System.Windows.Forms.Label();
            this.B_updateResults = new System.Windows.Forms.Button();
            this.TB_resultsStudentNo = new System.Windows.Forms.TextBox();
            this.Label_resultsStudentNo = new System.Windows.Forms.Label();
            this.updateResultGroup = new System.Windows.Forms.GroupBox();
            this.updateLessonGroup = new System.Windows.Forms.GroupBox();
            this.CLB_studentLessons = new System.Windows.Forms.CheckedListBox();
            this.TB_lessonsStudentNo = new System.Windows.Forms.TextBox();
            this.Label_lessonsStudentNo = new System.Windows.Forms.Label();
            this.B_updateLesson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updateStudentGroup.SuspendLayout();
            this.updateLessonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 520);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Öğrenciler",
            "Dersler",
            "Ders Notları"});
            this.comboBox1.Location = new System.Drawing.Point(15, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listelenecek Olan Tabloyu Seçiniz";
            // 
            // updateStudentGroup
            // 
            this.updateStudentGroup.Controls.Add(this.TB_studentNo);
            this.updateStudentGroup.Controls.Add(this.Label_studentNo);
            this.updateStudentGroup.Controls.Add(this.B_updateStudent);
            this.updateStudentGroup.Controls.Add(this.TB_birthPlace);
            this.updateStudentGroup.Controls.Add(this.Label_birthPlace);
            this.updateStudentGroup.Controls.Add(this.TB_birthYear);
            this.updateStudentGroup.Controls.Add(this.Label_birthYear);
            this.updateStudentGroup.Controls.Add(this.TB_lastName);
            this.updateStudentGroup.Controls.Add(this.Label_lastName);
            this.updateStudentGroup.Controls.Add(this.TB_name);
            this.updateStudentGroup.Controls.Add(this.Label_name);
            this.updateStudentGroup.Location = new System.Drawing.Point(576, 85);
            this.updateStudentGroup.Name = "updateStudentGroup";
            this.updateStudentGroup.Size = new System.Drawing.Size(224, 221);
            this.updateStudentGroup.TabIndex = 3;
            this.updateStudentGroup.TabStop = false;
            this.updateStudentGroup.Text = "Öğrenci Güncelle";
            // 
            // TB_studentNo
            // 
            this.TB_studentNo.Location = new System.Drawing.Point(112, 34);
            this.TB_studentNo.Name = "TB_studentNo";
            this.TB_studentNo.Size = new System.Drawing.Size(100, 20);
            this.TB_studentNo.TabIndex = 24;
            // 
            // Label_studentNo
            // 
            this.Label_studentNo.AutoSize = true;
            this.Label_studentNo.Location = new System.Drawing.Point(6, 41);
            this.Label_studentNo.Name = "Label_studentNo";
            this.Label_studentNo.Size = new System.Drawing.Size(100, 13);
            this.Label_studentNo.TabIndex = 23;
            this.Label_studentNo.Text = "Öğrenci Numarası : ";
            // 
            // B_updateStudent
            // 
            this.B_updateStudent.Location = new System.Drawing.Point(9, 164);
            this.B_updateStudent.Name = "B_updateStudent";
            this.B_updateStudent.Size = new System.Drawing.Size(203, 40);
            this.B_updateStudent.TabIndex = 22;
            this.B_updateStudent.Text = "Öğrenciyi Güncelle";
            this.B_updateStudent.UseVisualStyleBackColor = true;
            this.B_updateStudent.Click += new System.EventHandler(this.B_updateStudent_Click);
            // 
            // TB_birthPlace
            // 
            this.TB_birthPlace.Location = new System.Drawing.Point(112, 138);
            this.TB_birthPlace.Name = "TB_birthPlace";
            this.TB_birthPlace.Size = new System.Drawing.Size(100, 20);
            this.TB_birthPlace.TabIndex = 21;
            // 
            // Label_birthPlace
            // 
            this.Label_birthPlace.AutoSize = true;
            this.Label_birthPlace.Location = new System.Drawing.Point(6, 141);
            this.Label_birthPlace.Name = "Label_birthPlace";
            this.Label_birthPlace.Size = new System.Drawing.Size(71, 13);
            this.Label_birthPlace.TabIndex = 20;
            this.Label_birthPlace.Text = "Doğum Yeri : ";
            // 
            // TB_birthYear
            // 
            this.TB_birthYear.Location = new System.Drawing.Point(112, 112);
            this.TB_birthYear.Name = "TB_birthYear";
            this.TB_birthYear.Size = new System.Drawing.Size(100, 20);
            this.TB_birthYear.TabIndex = 19;
            // 
            // Label_birthYear
            // 
            this.Label_birthYear.AutoSize = true;
            this.Label_birthYear.Location = new System.Drawing.Point(6, 115);
            this.Label_birthYear.Name = "Label_birthYear";
            this.Label_birthYear.Size = new System.Drawing.Size(66, 13);
            this.Label_birthYear.TabIndex = 18;
            this.Label_birthYear.Text = "Doğum Yılı : ";
            // 
            // TB_lastName
            // 
            this.TB_lastName.Location = new System.Drawing.Point(112, 86);
            this.TB_lastName.Name = "TB_lastName";
            this.TB_lastName.Size = new System.Drawing.Size(100, 20);
            this.TB_lastName.TabIndex = 17;
            // 
            // Label_lastName
            // 
            this.Label_lastName.AutoSize = true;
            this.Label_lastName.Location = new System.Drawing.Point(6, 89);
            this.Label_lastName.Name = "Label_lastName";
            this.Label_lastName.Size = new System.Drawing.Size(48, 13);
            this.Label_lastName.TabIndex = 16;
            this.Label_lastName.Text = "Soyadı : ";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(112, 60);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(100, 20);
            this.TB_name.TabIndex = 15;
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Location = new System.Drawing.Point(6, 67);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(31, 13);
            this.Label_name.TabIndex = 14;
            this.Label_name.Text = "Adı : ";
            // 
            // B_updateResults
            // 
            this.B_updateResults.Location = new System.Drawing.Point(355, 565);
            this.B_updateResults.Name = "B_updateResults";
            this.B_updateResults.Size = new System.Drawing.Size(203, 40);
            this.B_updateResults.TabIndex = 27;
            this.B_updateResults.Text = "Notu Güncelle";
            this.B_updateResults.UseVisualStyleBackColor = true;
            this.B_updateResults.Click += new System.EventHandler(this.B_updateResults_Click);
            // 
            // TB_resultsStudentNo
            // 
            this.TB_resultsStudentNo.Location = new System.Drawing.Point(458, 539);
            this.TB_resultsStudentNo.Name = "TB_resultsStudentNo";
            this.TB_resultsStudentNo.Size = new System.Drawing.Size(100, 20);
            this.TB_resultsStudentNo.TabIndex = 29;
            // 
            // Label_resultsStudentNo
            // 
            this.Label_resultsStudentNo.AutoSize = true;
            this.Label_resultsStudentNo.Location = new System.Drawing.Point(352, 542);
            this.Label_resultsStudentNo.Name = "Label_resultsStudentNo";
            this.Label_resultsStudentNo.Size = new System.Drawing.Size(100, 13);
            this.Label_resultsStudentNo.TabIndex = 28;
            this.Label_resultsStudentNo.Text = "Öğrenci Numarası : ";
            // 
            // updateResultGroup
            // 
            this.updateResultGroup.Location = new System.Drawing.Point(346, 312);
            this.updateResultGroup.Name = "updateResultGroup";
            this.updateResultGroup.Size = new System.Drawing.Size(224, 221);
            this.updateResultGroup.TabIndex = 31;
            this.updateResultGroup.TabStop = false;
            this.updateResultGroup.Text = "Notlar Tablosuna Ekle";
            // 
            // updateLessonGroup
            // 
            this.updateLessonGroup.Controls.Add(this.CLB_studentLessons);
            this.updateLessonGroup.Controls.Add(this.TB_lessonsStudentNo);
            this.updateLessonGroup.Controls.Add(this.Label_lessonsStudentNo);
            this.updateLessonGroup.Controls.Add(this.B_updateLesson);
            this.updateLessonGroup.Location = new System.Drawing.Point(346, 85);
            this.updateLessonGroup.Name = "updateLessonGroup";
            this.updateLessonGroup.Size = new System.Drawing.Size(224, 221);
            this.updateLessonGroup.TabIndex = 30;
            this.updateLessonGroup.TabStop = false;
            this.updateLessonGroup.Text = "Dersleri Güncelle";
            // 
            // CLB_studentLessons
            // 
            this.CLB_studentLessons.FormattingEnabled = true;
            this.CLB_studentLessons.Items.AddRange(new object[] {
            "BM100",
            "BM200",
            "BM300"});
            this.CLB_studentLessons.Location = new System.Drawing.Point(9, 60);
            this.CLB_studentLessons.Name = "CLB_studentLessons";
            this.CLB_studentLessons.Size = new System.Drawing.Size(203, 94);
            this.CLB_studentLessons.TabIndex = 28;
            // 
            // TB_lessonsStudentNo
            // 
            this.TB_lessonsStudentNo.Location = new System.Drawing.Point(112, 34);
            this.TB_lessonsStudentNo.Name = "TB_lessonsStudentNo";
            this.TB_lessonsStudentNo.Size = new System.Drawing.Size(100, 20);
            this.TB_lessonsStudentNo.TabIndex = 24;
            // 
            // Label_lessonsStudentNo
            // 
            this.Label_lessonsStudentNo.AutoSize = true;
            this.Label_lessonsStudentNo.Location = new System.Drawing.Point(6, 41);
            this.Label_lessonsStudentNo.Name = "Label_lessonsStudentNo";
            this.Label_lessonsStudentNo.Size = new System.Drawing.Size(100, 13);
            this.Label_lessonsStudentNo.TabIndex = 23;
            this.Label_lessonsStudentNo.Text = "Öğrenci Numarası : ";
            // 
            // B_updateLesson
            // 
            this.B_updateLesson.Location = new System.Drawing.Point(9, 164);
            this.B_updateLesson.Name = "B_updateLesson";
            this.B_updateLesson.Size = new System.Drawing.Size(203, 40);
            this.B_updateLesson.TabIndex = 22;
            this.B_updateLesson.Text = "Dersi Güncelle";
            this.B_updateLesson.UseVisualStyleBackColor = true;
            this.B_updateLesson.Click += new System.EventHandler(this.B_updateLesson_Click);
            // 
            // updateDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 631);
            this.Controls.Add(this.B_updateResults);
            this.Controls.Add(this.updateResultGroup);
            this.Controls.Add(this.TB_resultsStudentNo);
            this.Controls.Add(this.updateLessonGroup);
            this.Controls.Add(this.Label_resultsStudentNo);
            this.Controls.Add(this.updateStudentGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "updateDatas";
            this.Text = "Kayıt Güncelleme";
            this.Load += new System.EventHandler(this.updateDatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updateStudentGroup.ResumeLayout(false);
            this.updateStudentGroup.PerformLayout();
            this.updateLessonGroup.ResumeLayout(false);
            this.updateLessonGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox updateStudentGroup;
        private System.Windows.Forms.TextBox TB_studentNo;
        private System.Windows.Forms.Label Label_studentNo;
        private System.Windows.Forms.Button B_updateStudent;
        private System.Windows.Forms.TextBox TB_birthPlace;
        private System.Windows.Forms.Label Label_birthPlace;
        private System.Windows.Forms.TextBox TB_birthYear;
        private System.Windows.Forms.Label Label_birthYear;
        private System.Windows.Forms.TextBox TB_lastName;
        private System.Windows.Forms.Label Label_lastName;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.Button B_updateResults;
        private System.Windows.Forms.TextBox TB_resultsStudentNo;
        private System.Windows.Forms.Label Label_resultsStudentNo;
        private System.Windows.Forms.GroupBox updateResultGroup;
        private System.Windows.Forms.GroupBox updateLessonGroup;
        private System.Windows.Forms.CheckedListBox CLB_studentLessons;
        private System.Windows.Forms.TextBox TB_lessonsStudentNo;
        private System.Windows.Forms.Label Label_lessonsStudentNo;
        private System.Windows.Forms.Button B_updateLesson;
    }
}