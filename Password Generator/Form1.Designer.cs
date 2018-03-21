namespace Password_Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_ParolaUzunlugu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ParolaMetni = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_GelismisAyarlariGoster = new System.Windows.Forms.CheckBox();
            this.panel_ParolaUret = new System.Windows.Forms.Panel();
            this.button_ParolaUret = new System.Windows.Forms.Button();
            this.panel_GelismisAyarlar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_ParolaYenile = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_TumKarakterTiplerineIzinVer = new System.Windows.Forms.RadioButton();
            this.radioButton_OkunabilirYap = new System.Windows.Forms.RadioButton();
            this.checkBox_A_z = new System.Windows.Forms.CheckBox();
            this.checkBox_aa_zz = new System.Windows.Forms.CheckBox();
            this.checkBox_OzelKarakter = new System.Windows.Forms.CheckBox();
            this.checkBox_Rakamlar = new System.Windows.Forms.CheckBox();
            this.timer_CopyBilgi = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel_ParolaUret.SuspendLayout();
            this.panel_GelismisAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ParolaYenile)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_ParolaUzunlugu
            // 
            this.comboBox_ParolaUzunlugu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ParolaUzunlugu.DropDownHeight = 60;
            this.comboBox_ParolaUzunlugu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ParolaUzunlugu.DropDownWidth = 100;
            this.comboBox_ParolaUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_ParolaUzunlugu.FormattingEnabled = true;
            this.comboBox_ParolaUzunlugu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_ParolaUzunlugu.IntegralHeight = false;
            this.comboBox_ParolaUzunlugu.ItemHeight = 20;
            this.comboBox_ParolaUzunlugu.Items.AddRange(new object[] {
            "6 ",
            "7",
            "8 ",
            "9 ",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.comboBox_ParolaUzunlugu.Location = new System.Drawing.Point(7, 89);
            this.comboBox_ParolaUzunlugu.MaxLength = 3;
            this.comboBox_ParolaUzunlugu.Name = "comboBox_ParolaUzunlugu";
            this.comboBox_ParolaUzunlugu.Size = new System.Drawing.Size(373, 28);
            this.comboBox_ParolaUzunlugu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parolanız:";
            // 
            // textBox_ParolaMetni
            // 
            this.textBox_ParolaMetni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ParolaMetni.Location = new System.Drawing.Point(7, 27);
            this.textBox_ParolaMetni.Name = "textBox_ParolaMetni";
            this.textBox_ParolaMetni.Size = new System.Drawing.Size(340, 26);
            this.textBox_ParolaMetni.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_ParolaYenile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_ParolaMetni);
            this.panel1.Controls.Add(this.comboBox_ParolaUzunlugu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 125);
            this.panel1.TabIndex = 3;
            // 
            // checkBox_GelismisAyarlariGoster
            // 
            this.checkBox_GelismisAyarlariGoster.AutoSize = true;
            this.checkBox_GelismisAyarlariGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_GelismisAyarlariGoster.Location = new System.Drawing.Point(12, 143);
            this.checkBox_GelismisAyarlariGoster.Name = "checkBox_GelismisAyarlariGoster";
            this.checkBox_GelismisAyarlariGoster.Size = new System.Drawing.Size(139, 24);
            this.checkBox_GelismisAyarlariGoster.TabIndex = 4;
            this.checkBox_GelismisAyarlariGoster.Text = "Gelişmiş ayarlar";
            this.checkBox_GelismisAyarlariGoster.UseVisualStyleBackColor = true;
            this.checkBox_GelismisAyarlariGoster.CheckedChanged += new System.EventHandler(this.checkBox_GelismisAyarlariGoster_CheckedChanged);
            // 
            // panel_ParolaUret
            // 
            this.panel_ParolaUret.Controls.Add(this.button_ParolaUret);
            this.panel_ParolaUret.Location = new System.Drawing.Point(12, 173);
            this.panel_ParolaUret.Name = "panel_ParolaUret";
            this.panel_ParolaUret.Size = new System.Drawing.Size(390, 66);
            this.panel_ParolaUret.TabIndex = 3;
            // 
            // button_ParolaUret
            // 
            this.button_ParolaUret.Location = new System.Drawing.Point(102, 3);
            this.button_ParolaUret.Name = "button_ParolaUret";
            this.button_ParolaUret.Size = new System.Drawing.Size(201, 60);
            this.button_ParolaUret.TabIndex = 0;
            this.button_ParolaUret.Text = "Parola Üret";
            this.button_ParolaUret.UseVisualStyleBackColor = true;
            this.button_ParolaUret.Click += new System.EventHandler(this.button_ParolaUret_Click);
            // 
            // panel_GelismisAyarlar
            // 
            this.panel_GelismisAyarlar.BackColor = System.Drawing.Color.DarkGray;
            this.panel_GelismisAyarlar.Controls.Add(this.checkBox_Rakamlar);
            this.panel_GelismisAyarlar.Controls.Add(this.checkBox_OzelKarakter);
            this.panel_GelismisAyarlar.Controls.Add(this.checkBox_aa_zz);
            this.panel_GelismisAyarlar.Controls.Add(this.checkBox_A_z);
            this.panel_GelismisAyarlar.Controls.Add(this.radioButton_OkunabilirYap);
            this.panel_GelismisAyarlar.Controls.Add(this.radioButton_TumKarakterTiplerineIzinVer);
            this.panel_GelismisAyarlar.Location = new System.Drawing.Point(12, 245);
            this.panel_GelismisAyarlar.Name = "panel_GelismisAyarlar";
            this.panel_GelismisAyarlar.Size = new System.Drawing.Size(390, 107);
            this.panel_GelismisAyarlar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola Uzunluğu:";
            // 
            // pictureBox_ParolaYenile
            // 
            this.pictureBox_ParolaYenile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ParolaYenile.Image")));
            this.pictureBox_ParolaYenile.Location = new System.Drawing.Point(353, 27);
            this.pictureBox_ParolaYenile.Name = "pictureBox_ParolaYenile";
            this.pictureBox_ParolaYenile.Size = new System.Drawing.Size(27, 26);
            this.pictureBox_ParolaYenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ParolaYenile.TabIndex = 3;
            this.pictureBox_ParolaYenile.TabStop = false;
            this.pictureBox_ParolaYenile.Click += new System.EventHandler(this.button_ParolaUret_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(223, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parolayı Kopyala";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButton_TumKarakterTiplerineIzinVer
            // 
            this.radioButton_TumKarakterTiplerineIzinVer.AutoSize = true;
            this.radioButton_TumKarakterTiplerineIzinVer.Checked = true;
            this.radioButton_TumKarakterTiplerineIzinVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_TumKarakterTiplerineIzinVer.Location = new System.Drawing.Point(7, 18);
            this.radioButton_TumKarakterTiplerineIzinVer.Name = "radioButton_TumKarakterTiplerineIzinVer";
            this.radioButton_TumKarakterTiplerineIzinVer.Size = new System.Drawing.Size(222, 21);
            this.radioButton_TumKarakterTiplerineIzinVer.TabIndex = 0;
            this.radioButton_TumKarakterTiplerineIzinVer.TabStop = true;
            this.radioButton_TumKarakterTiplerineIzinVer.Text = "Tüm Karakter Tiplerine İzin Ver";
            this.radioButton_TumKarakterTiplerineIzinVer.UseVisualStyleBackColor = true;
            this.radioButton_TumKarakterTiplerineIzinVer.CheckedChanged += new System.EventHandler(this.radioButton_TumKarakterTiplerineIzinVer_CheckedChanged);
            // 
            // radioButton_OkunabilirYap
            // 
            this.radioButton_OkunabilirYap.AutoSize = true;
            this.radioButton_OkunabilirYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_OkunabilirYap.Location = new System.Drawing.Point(7, 45);
            this.radioButton_OkunabilirYap.Name = "radioButton_OkunabilirYap";
            this.radioButton_OkunabilirYap.Size = new System.Drawing.Size(119, 21);
            this.radioButton_OkunabilirYap.TabIndex = 0;
            this.radioButton_OkunabilirYap.Text = "Okunabilir Yap";
            this.radioButton_OkunabilirYap.UseVisualStyleBackColor = true;
            this.radioButton_OkunabilirYap.CheckedChanged += new System.EventHandler(this.radioButton_OkunabilirYap_CheckedChanged);
            // 
            // checkBox_A_z
            // 
            this.checkBox_A_z.AutoSize = true;
            this.checkBox_A_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_A_z.Location = new System.Drawing.Point(7, 72);
            this.checkBox_A_z.Name = "checkBox_A_z";
            this.checkBox_A_z.Size = new System.Drawing.Size(48, 21);
            this.checkBox_A_z.TabIndex = 1;
            this.checkBox_A_z.Text = "A-z";
            this.checkBox_A_z.UseVisualStyleBackColor = true;
            // 
            // checkBox_aa_zz
            // 
            this.checkBox_aa_zz.AutoSize = true;
            this.checkBox_aa_zz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_aa_zz.Location = new System.Drawing.Point(170, 72);
            this.checkBox_aa_zz.Name = "checkBox_aa_zz";
            this.checkBox_aa_zz.Size = new System.Drawing.Size(47, 21);
            this.checkBox_aa_zz.TabIndex = 1;
            this.checkBox_aa_zz.Text = "a-z";
            this.checkBox_aa_zz.UseVisualStyleBackColor = true;
            // 
            // checkBox_OzelKarakter
            // 
            this.checkBox_OzelKarakter.AutoSize = true;
            this.checkBox_OzelKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_OzelKarakter.Location = new System.Drawing.Point(250, 72);
            this.checkBox_OzelKarakter.Name = "checkBox_OzelKarakter";
            this.checkBox_OzelKarakter.Size = new System.Drawing.Size(130, 21);
            this.checkBox_OzelKarakter.TabIndex = 1;
            this.checkBox_OzelKarakter.Text = "Özel Karakterler";
            this.checkBox_OzelKarakter.UseVisualStyleBackColor = true;
            // 
            // checkBox_Rakamlar
            // 
            this.checkBox_Rakamlar.AutoSize = true;
            this.checkBox_Rakamlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_Rakamlar.Location = new System.Drawing.Point(85, 72);
            this.checkBox_Rakamlar.Name = "checkBox_Rakamlar";
            this.checkBox_Rakamlar.Size = new System.Drawing.Size(48, 21);
            this.checkBox_Rakamlar.TabIndex = 1;
            this.checkBox_Rakamlar.Text = "0-9";
            this.checkBox_Rakamlar.UseVisualStyleBackColor = true;
            // 
            // timer_CopyBilgi
            // 
            this.timer_CopyBilgi.Interval = 1000;
            this.timer_CopyBilgi.Tick += new System.EventHandler(this.timer_CopyBilgi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(410, 361);
            this.Controls.Add(this.panel_GelismisAyarlar);
            this.Controls.Add(this.panel_ParolaUret);
            this.Controls.Add(this.checkBox_GelismisAyarlariGoster);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 400);
            this.MinimumSize = new System.Drawing.Size(426, 250);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Üretici | Mustafa Ergeç";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ParolaUret.ResumeLayout(false);
            this.panel_GelismisAyarlar.ResumeLayout(false);
            this.panel_GelismisAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ParolaYenile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ParolaUzunlugu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ParolaMetni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_GelismisAyarlariGoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_ParolaUret;
        private System.Windows.Forms.Button button_ParolaUret;
        private System.Windows.Forms.Panel panel_GelismisAyarlar;
        private System.Windows.Forms.PictureBox pictureBox_ParolaYenile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Rakamlar;
        private System.Windows.Forms.CheckBox checkBox_OzelKarakter;
        private System.Windows.Forms.CheckBox checkBox_aa_zz;
        private System.Windows.Forms.CheckBox checkBox_A_z;
        private System.Windows.Forms.RadioButton radioButton_OkunabilirYap;
        private System.Windows.Forms.RadioButton radioButton_TumKarakterTiplerineIzinVer;
        private System.Windows.Forms.Timer timer_CopyBilgi;
    }
}

