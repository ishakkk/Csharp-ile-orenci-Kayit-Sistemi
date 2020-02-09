namespace BilgisayarMuhendislikOzelKonular
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_name = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.Label_lastName = new System.Windows.Forms.Label();
            this.TB_lastName = new System.Windows.Forms.TextBox();
            this.TB_birthPlace = new System.Windows.Forms.TextBox();
            this.Label_birthPlace = new System.Windows.Forms.Label();
            this.TB_birthYear = new System.Windows.Forms.TextBox();
            this.Label_birthYear = new System.Windows.Forms.Label();
            this.MENU_mainMenu = new System.Windows.Forms.MenuStrip();
            this.anaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veritabanıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersNotlarıTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkıiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonrakiKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifKayıtSırasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_studentNo = new System.Windows.Forms.TextBox();
            this.Label_studentNo = new System.Windows.Forms.Label();
            this.studentGroup = new System.Windows.Forms.GroupBox();
            this.lessonsGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_bm100 = new System.Windows.Forms.TextBox();
            this.TB_bm200 = new System.Windows.Forms.TextBox();
            this.TB_bm300 = new System.Windows.Forms.TextBox();
            this.exams = new System.Windows.Forms.GroupBox();
            this.CLB_studentLessons = new System.Windows.Forms.CheckedListBox();
            this.MENU_mainMenu.SuspendLayout();
            this.studentGroup.SuspendLayout();
            this.lessonsGroup.SuspendLayout();
            this.exams.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Location = new System.Drawing.Point(46, 40);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(31, 13);
            this.Label_name.TabIndex = 0;
            this.Label_name.Text = "Adı : ";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(152, 33);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(121, 20);
            this.TB_name.TabIndex = 1;
            // 
            // Label_lastName
            // 
            this.Label_lastName.AutoSize = true;
            this.Label_lastName.Location = new System.Drawing.Point(46, 62);
            this.Label_lastName.Name = "Label_lastName";
            this.Label_lastName.Size = new System.Drawing.Size(48, 13);
            this.Label_lastName.TabIndex = 2;
            this.Label_lastName.Text = "Soyadı : ";
            // 
            // TB_lastName
            // 
            this.TB_lastName.Location = new System.Drawing.Point(152, 59);
            this.TB_lastName.Name = "TB_lastName";
            this.TB_lastName.Size = new System.Drawing.Size(121, 20);
            this.TB_lastName.TabIndex = 3;
            // 
            // TB_birthPlace
            // 
            this.TB_birthPlace.Location = new System.Drawing.Point(152, 111);
            this.TB_birthPlace.Name = "TB_birthPlace";
            this.TB_birthPlace.Size = new System.Drawing.Size(121, 20);
            this.TB_birthPlace.TabIndex = 7;
            // 
            // Label_birthPlace
            // 
            this.Label_birthPlace.AutoSize = true;
            this.Label_birthPlace.Location = new System.Drawing.Point(46, 114);
            this.Label_birthPlace.Name = "Label_birthPlace";
            this.Label_birthPlace.Size = new System.Drawing.Size(71, 13);
            this.Label_birthPlace.TabIndex = 6;
            this.Label_birthPlace.Text = "Doğum Yeri : ";
            // 
            // TB_birthYear
            // 
            this.TB_birthYear.Location = new System.Drawing.Point(152, 85);
            this.TB_birthYear.Name = "TB_birthYear";
            this.TB_birthYear.Size = new System.Drawing.Size(121, 20);
            this.TB_birthYear.TabIndex = 5;
            // 
            // Label_birthYear
            // 
            this.Label_birthYear.AutoSize = true;
            this.Label_birthYear.Location = new System.Drawing.Point(46, 88);
            this.Label_birthYear.Name = "Label_birthYear";
            this.Label_birthYear.Size = new System.Drawing.Size(66, 13);
            this.Label_birthYear.TabIndex = 4;
            this.Label_birthYear.Text = "Doğum Yılı : ";
            // 
            // MENU_mainMenu
            // 
            this.MENU_mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaToolStripMenuItem,
            this.kayıtİşlemleriToolStripMenuItem,
            this.kayıtGörüntüleToolStripMenuItem,
            this.verilerToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.MENU_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.MENU_mainMenu.Name = "MENU_mainMenu";
            this.MENU_mainMenu.Size = new System.Drawing.Size(713, 24);
            this.MENU_mainMenu.TabIndex = 11;
            this.MENU_mainMenu.Text = "menuStrip1";
            // 
            // anaToolStripMenuItem
            // 
            this.anaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veritabanıOluşturToolStripMenuItem,
            this.tabloOluşturToolStripMenuItem,
            this.çıkıiToolStripMenuItem});
            this.anaToolStripMenuItem.Name = "anaToolStripMenuItem";
            this.anaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaToolStripMenuItem.Text = "Veritabanı";
            // 
            // veritabanıOluşturToolStripMenuItem
            // 
            this.veritabanıOluşturToolStripMenuItem.Name = "veritabanıOluşturToolStripMenuItem";
            this.veritabanıOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veritabanıOluşturToolStripMenuItem.Text = "Veritabanı Oluştur";
            this.veritabanıOluşturToolStripMenuItem.Click += new System.EventHandler(this.veritabanıOluşturToolStripMenuItem_Click);
            // 
            // tabloOluşturToolStripMenuItem
            // 
            this.tabloOluşturToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciTablosuToolStripMenuItem,
            this.dToolStripMenuItem,
            this.dersNotlarıTablosuToolStripMenuItem});
            this.tabloOluşturToolStripMenuItem.Name = "tabloOluşturToolStripMenuItem";
            this.tabloOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabloOluşturToolStripMenuItem.Text = "Tablo Oluştur";
            // 
            // öğrenciTablosuToolStripMenuItem
            // 
            this.öğrenciTablosuToolStripMenuItem.Name = "öğrenciTablosuToolStripMenuItem";
            this.öğrenciTablosuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciTablosuToolStripMenuItem.Text = "Öğrenci Tablosu";
            this.öğrenciTablosuToolStripMenuItem.Click += new System.EventHandler(this.öğrenciTablosuToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem.Text = "Dersler Tablosu";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // dersNotlarıTablosuToolStripMenuItem
            // 
            this.dersNotlarıTablosuToolStripMenuItem.Name = "dersNotlarıTablosuToolStripMenuItem";
            this.dersNotlarıTablosuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dersNotlarıTablosuToolStripMenuItem.Text = "Ders Notları Tablosu";
            this.dersNotlarıTablosuToolStripMenuItem.Click += new System.EventHandler(this.dersNotlarıTablosuToolStripMenuItem_Click);
            // 
            // çıkıiToolStripMenuItem
            // 
            this.çıkıiToolStripMenuItem.Name = "çıkıiToolStripMenuItem";
            this.çıkıiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkıiToolStripMenuItem.Text = "Çıkış";
            // 
            // kayıtİşlemleriToolStripMenuItem
            // 
            this.kayıtİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem,
            this.kayıtGüncellemeToolStripMenuItem,
            this.kayıtSilmeToolStripMenuItem});
            this.kayıtİşlemleriToolStripMenuItem.Name = "kayıtİşlemleriToolStripMenuItem";
            this.kayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.kayıtİşlemleriToolStripMenuItem.Text = "Kayıt İşlemleri";
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt Ekle";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click);
            // 
            // kayıtGüncellemeToolStripMenuItem
            // 
            this.kayıtGüncellemeToolStripMenuItem.Name = "kayıtGüncellemeToolStripMenuItem";
            this.kayıtGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayıtGüncellemeToolStripMenuItem.Text = "Kayıt Güncelleme";
            this.kayıtGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.kayıtGüncellemeToolStripMenuItem_Click);
            // 
            // kayıtSilmeToolStripMenuItem
            // 
            this.kayıtSilmeToolStripMenuItem.Name = "kayıtSilmeToolStripMenuItem";
            this.kayıtSilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayıtSilmeToolStripMenuItem.Text = "Kayıt Silme";
            this.kayıtSilmeToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilmeToolStripMenuItem_Click);
            // 
            // kayıtGörüntüleToolStripMenuItem
            // 
            this.kayıtGörüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtGösterToolStripMenuItem,
            this.sonrakiKayıtToolStripMenuItem,
            this.öncekiKayıtToolStripMenuItem,
            this.toplamKayıtToolStripMenuItem,
            this.aktifKayıtSırasıToolStripMenuItem});
            this.kayıtGörüntüleToolStripMenuItem.Name = "kayıtGörüntüleToolStripMenuItem";
            this.kayıtGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.kayıtGörüntüleToolStripMenuItem.Text = "Kayıt Görüntüle";
            // 
            // kayıtGösterToolStripMenuItem
            // 
            this.kayıtGösterToolStripMenuItem.Name = "kayıtGösterToolStripMenuItem";
            this.kayıtGösterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kayıtGösterToolStripMenuItem.Text = "Kayıt Göster";
            this.kayıtGösterToolStripMenuItem.Click += new System.EventHandler(this.kayıtGösterToolStripMenuItem_Click);
            // 
            // sonrakiKayıtToolStripMenuItem
            // 
            this.sonrakiKayıtToolStripMenuItem.Name = "sonrakiKayıtToolStripMenuItem";
            this.sonrakiKayıtToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sonrakiKayıtToolStripMenuItem.Text = "Sonraki Kayıt";
            this.sonrakiKayıtToolStripMenuItem.Click += new System.EventHandler(this.sonrakiKayıtToolStripMenuItem_Click);
            // 
            // öncekiKayıtToolStripMenuItem
            // 
            this.öncekiKayıtToolStripMenuItem.Name = "öncekiKayıtToolStripMenuItem";
            this.öncekiKayıtToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.öncekiKayıtToolStripMenuItem.Text = "Önceki Kayıt";
            this.öncekiKayıtToolStripMenuItem.Click += new System.EventHandler(this.öncekiKayıtToolStripMenuItem_Click);
            // 
            // toplamKayıtToolStripMenuItem
            // 
            this.toplamKayıtToolStripMenuItem.Name = "toplamKayıtToolStripMenuItem";
            this.toplamKayıtToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.toplamKayıtToolStripMenuItem.Text = "Toplam Kayıt";
            this.toplamKayıtToolStripMenuItem.Click += new System.EventHandler(this.toplamKayıtToolStripMenuItem_Click);
            // 
            // aktifKayıtSırasıToolStripMenuItem
            // 
            this.aktifKayıtSırasıToolStripMenuItem.Name = "aktifKayıtSırasıToolStripMenuItem";
            this.aktifKayıtSırasıToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aktifKayıtSırasıToolStripMenuItem.Text = "Aktif Kayıt Sırası";
            this.aktifKayıtSırasıToolStripMenuItem.Click += new System.EventHandler(this.aktifKayıtSırasıToolStripMenuItem_Click);
            // 
            // verilerToolStripMenuItem
            // 
            this.verilerToolStripMenuItem.Name = "verilerToolStripMenuItem";
            this.verilerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.verilerToolStripMenuItem.Text = "Veriler";
            this.verilerToolStripMenuItem.Click += new System.EventHandler(this.verilerToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // TB_studentNo
            // 
            this.TB_studentNo.Location = new System.Drawing.Point(113, 27);
            this.TB_studentNo.Name = "TB_studentNo";
            this.TB_studentNo.Size = new System.Drawing.Size(121, 20);
            this.TB_studentNo.TabIndex = 13;
            // 
            // Label_studentNo
            // 
            this.Label_studentNo.AutoSize = true;
            this.Label_studentNo.Location = new System.Drawing.Point(7, 30);
            this.Label_studentNo.Name = "Label_studentNo";
            this.Label_studentNo.Size = new System.Drawing.Size(100, 13);
            this.Label_studentNo.TabIndex = 12;
            this.Label_studentNo.Text = "Öğrenci Numarası : ";
            // 
            // studentGroup
            // 
            this.studentGroup.Controls.Add(this.Label_name);
            this.studentGroup.Controls.Add(this.TB_name);
            this.studentGroup.Controls.Add(this.Label_lastName);
            this.studentGroup.Controls.Add(this.TB_lastName);
            this.studentGroup.Controls.Add(this.Label_birthYear);
            this.studentGroup.Controls.Add(this.TB_birthYear);
            this.studentGroup.Controls.Add(this.TB_birthPlace);
            this.studentGroup.Controls.Add(this.Label_birthPlace);
            this.studentGroup.Location = new System.Drawing.Point(10, 53);
            this.studentGroup.Name = "studentGroup";
            this.studentGroup.Size = new System.Drawing.Size(340, 164);
            this.studentGroup.TabIndex = 16;
            this.studentGroup.TabStop = false;
            this.studentGroup.Text = "Öğrenci";
            // 
            // lessonsGroup
            // 
            this.lessonsGroup.Controls.Add(this.label3);
            this.lessonsGroup.Controls.Add(this.label1);
            this.lessonsGroup.Controls.Add(this.label2);
            this.lessonsGroup.Controls.Add(this.TB_bm100);
            this.lessonsGroup.Controls.Add(this.TB_bm200);
            this.lessonsGroup.Controls.Add(this.TB_bm300);
            this.lessonsGroup.Location = new System.Drawing.Point(10, 223);
            this.lessonsGroup.Name = "lessonsGroup";
            this.lessonsGroup.Size = new System.Drawing.Size(340, 164);
            this.lessonsGroup.TabIndex = 17;
            this.lessonsGroup.TabStop = false;
            this.lessonsGroup.Text = "Dersler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "BM300 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BM200 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BM100 : ";
            // 
            // TB_bm100
            // 
            this.TB_bm100.Location = new System.Drawing.Point(165, 49);
            this.TB_bm100.Name = "TB_bm100";
            this.TB_bm100.Size = new System.Drawing.Size(121, 20);
            this.TB_bm100.TabIndex = 1;
            // 
            // TB_bm200
            // 
            this.TB_bm200.Location = new System.Drawing.Point(165, 75);
            this.TB_bm200.Name = "TB_bm200";
            this.TB_bm200.Size = new System.Drawing.Size(121, 20);
            this.TB_bm200.TabIndex = 3;
            // 
            // TB_bm300
            // 
            this.TB_bm300.Location = new System.Drawing.Point(165, 101);
            this.TB_bm300.Name = "TB_bm300";
            this.TB_bm300.Size = new System.Drawing.Size(121, 20);
            this.TB_bm300.TabIndex = 5;
            // 
            // exams
            // 
            this.exams.Controls.Add(this.CLB_studentLessons);
            this.exams.Location = new System.Drawing.Point(356, 53);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(340, 164);
            this.exams.TabIndex = 18;
            this.exams.TabStop = false;
            this.exams.Text = "Notlar";
            // 
            // CLB_studentLessons
            // 
            this.CLB_studentLessons.FormattingEnabled = true;
            this.CLB_studentLessons.Items.AddRange(new object[] {
            "BM100",
            "BM200",
            "BM300"});
            this.CLB_studentLessons.Location = new System.Drawing.Point(6, 25);
            this.CLB_studentLessons.Name = "CLB_studentLessons";
            this.CLB_studentLessons.Size = new System.Drawing.Size(319, 124);
            this.CLB_studentLessons.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 396);
            this.Controls.Add(this.lessonsGroup);
            this.Controls.Add(this.exams);
            this.Controls.Add(this.studentGroup);
            this.Controls.Add(this.TB_studentNo);
            this.Controls.Add(this.Label_studentNo);
            this.Controls.Add(this.MENU_mainMenu);
            this.MainMenuStrip = this.MENU_mainMenu;
            this.Name = "Form1";
            this.Text = "Bilgisayar Mühendisliği Özel Konular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MENU_mainMenu.ResumeLayout(false);
            this.MENU_mainMenu.PerformLayout();
            this.studentGroup.ResumeLayout(false);
            this.studentGroup.PerformLayout();
            this.lessonsGroup.ResumeLayout(false);
            this.lessonsGroup.PerformLayout();
            this.exams.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label Label_lastName;
        private System.Windows.Forms.TextBox TB_lastName;
        private System.Windows.Forms.TextBox TB_birthPlace;
        private System.Windows.Forms.Label Label_birthPlace;
        private System.Windows.Forms.TextBox TB_birthYear;
        private System.Windows.Forms.Label Label_birthYear;
        private System.Windows.Forms.ToolStripMenuItem anaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritabanıOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkıiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonrakiKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifKayıtSırasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MENU_mainMenu;
        private System.Windows.Forms.ToolStripMenuItem öğrenciTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersNotlarıTablosuToolStripMenuItem;
        private System.Windows.Forms.TextBox TB_studentNo;
        private System.Windows.Forms.Label Label_studentNo;
        private System.Windows.Forms.GroupBox studentGroup;
        private System.Windows.Forms.GroupBox lessonsGroup;
        private System.Windows.Forms.GroupBox exams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_bm100;
        private System.Windows.Forms.TextBox TB_bm200;
        private System.Windows.Forms.TextBox TB_bm300;
        private System.Windows.Forms.CheckedListBox CLB_studentLessons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

