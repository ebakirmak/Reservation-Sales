namespace NYPFINAL
{
    partial class frmAnasayfa
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
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.btnSEkle = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblVaris = new System.Windows.Forms.Label();
            this.lblKalkis = new System.Windows.Forms.Label();
            
            this.lblDonus = new System.Windows.Forms.Label();
            this.dateDonus = new System.Windows.Forms.DateTimePicker();
            this.dateGidis = new System.Windows.Forms.DateTimePicker();
            this.lblGTarih = new System.Windows.Forms.Label();
            this.cmbSefer = new System.Windows.Forms.ComboBox();
            this.lblSefer = new System.Windows.Forms.Label();
            this.btnRezervasyonTip = new System.Windows.Forms.Button();
            this.numYolcuSayi = new System.Windows.Forms.NumericUpDown();
            this.lblYolcuSayisi = new System.Windows.Forms.Label();
            this.lblRTip = new System.Windows.Forms.Label();
            this.cmbRTip = new System.Windows.Forms.ComboBox();
            this.xtraYolcuBilgi = new DevExpress.XtraTab.XtraTabPage();
            this.cmbYolcuTip = new System.Windows.Forms.ComboBox();
            this.lblYolcuTip = new System.Windows.Forms.Label();
            this.btnKisiBilgileriEkle = new System.Windows.Forms.Button();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.xtraOdeme = new DevExpress.XtraTab.XtraTabPage();
            this.lblPuan = new System.Windows.Forms.Label();
            this.grpHavale = new System.Windows.Forms.GroupBox();
            this.txtIBANNo = new System.Windows.Forms.TextBox();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.lblSubeAd = new System.Windows.Forms.Label();
            this.lblBankaAd = new System.Windows.Forms.Label();
            this.txtBankaAdi = new System.Windows.Forms.TextBox();
            this.chkPuan = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.grpKK = new System.Windows.Forms.GroupBox();
            this.cmbKKAd = new System.Windows.Forms.ComboBox();
            this.lblKKAdi = new System.Windows.Forms.Label();
            this.lblKKNo = new System.Windows.Forms.Label();
            this.txtKKNo = new System.Windows.Forms.TextBox();
            this.cmbOdemeTip = new System.Windows.Forms.ComboBox();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.lblOdemeMesaj = new System.Windows.Forms.Label();
            this.xtraBiletBilgi = new DevExpress.XtraTab.XtraTabPage();
            this.xtraSefer = new DevExpress.XtraTab.XtraTabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.xtraRezerve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYolcuSayi)).BeginInit();
            this.xtraYolcuBilgi.SuspendLayout();
            this.xtraOdeme.SuspendLayout();
            this.grpHavale.SuspendLayout();
            this.grpKK.SuspendLayout();
            this.xtraSefer.SuspendLayout();
            this.SuspendLayout();
            // 
            // numFiyat
            // 
            this.numFiyat.Location = new System.Drawing.Point(133, 102);
            this.numFiyat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(222, 21);
            this.numFiyat.TabIndex = 2;
            // 
            // cmbVaris
            // 
            this.cmbVaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbVaris.Location = new System.Drawing.Point(133, 69);
            this.cmbVaris.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(219, 21);
            this.cmbVaris.TabIndex = 1;
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbKalkis.Location = new System.Drawing.Point(133, 36);
            this.cmbKalkis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(219, 21);
            this.cmbKalkis.TabIndex = 0;
            // 
            // btnSEkle
            // 
            this.btnSEkle.Location = new System.Drawing.Point(274, 224);
            this.btnSEkle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSEkle.Name = "btnSEkle";
            this.btnSEkle.Size = new System.Drawing.Size(180, 40);
            this.btnSEkle.TabIndex = 3;
            this.btnSEkle.Text = "EKLE";
            this.btnSEkle.UseVisualStyleBackColor = true;
            this.btnSEkle.Click += new System.EventHandler(this.btnSEkle_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(59, 110);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 13);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // lblVaris
            // 
            this.lblVaris.AutoSize = true;
            this.lblVaris.Location = new System.Drawing.Point(39, 77);
            this.lblVaris.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVaris.Name = "lblVaris";
            this.lblVaris.Size = new System.Drawing.Size(58, 13);
            this.lblVaris.TabIndex = 0;
            this.lblVaris.Text = "Varış Yeri :";
            // 
            // lblKalkis
            // 
            this.lblKalkis.AutoSize = true;
            this.lblKalkis.Location = new System.Drawing.Point(39, 44);
            this.lblKalkis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKalkis.Name = "lblKalkis";
            this.lblKalkis.Size = new System.Drawing.Size(61, 13);
            this.lblKalkis.TabIndex = 0;
            this.lblKalkis.Text = "Kalkış Yeri :";
            // 
            // tabControl
            // 
            this.tabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tabControl.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabControl.Location = new System.Drawing.Point(7, 11);
            this.tabControl.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.xtraRezerve;
            this.tabControl.Size = new System.Drawing.Size(497, 297);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraRezerve,
            this.xtraYolcuBilgi,
            this.xtraOdeme,
            this.xtraBiletBilgi,
            this.xtraSefer});
            // 
            // xtraRezerve
            // 
            this.xtraRezerve.Controls.Add(this.lblDonus);
            this.xtraRezerve.Controls.Add(this.dateDonus);
            this.xtraRezerve.Controls.Add(this.dateGidis);
            this.xtraRezerve.Controls.Add(this.lblGTarih);
            this.xtraRezerve.Controls.Add(this.cmbSefer);
            this.xtraRezerve.Controls.Add(this.lblSefer);
            this.xtraRezerve.Controls.Add(this.btnRezervasyonTip);
            this.xtraRezerve.Controls.Add(this.numYolcuSayi);
            this.xtraRezerve.Controls.Add(this.lblYolcuSayisi);
            this.xtraRezerve.Controls.Add(this.lblRTip);
            this.xtraRezerve.Controls.Add(this.cmbRTip);
            this.xtraRezerve.Margin = new System.Windows.Forms.Padding(4);
            this.xtraRezerve.Name = "xtraRezerve";
            this.xtraRezerve.Size = new System.Drawing.Size(489, 267);
            this.xtraRezerve.Text = "Rezervasyon";
            // 
            // lblDonus
            // 
            this.lblDonus.AutoSize = true;
            this.lblDonus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonus.Location = new System.Drawing.Point(53, 161);
            this.lblDonus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDonus.Name = "lblDonus";
            this.lblDonus.Size = new System.Drawing.Size(129, 23);
            this.lblDonus.TabIndex = 52;
            this.lblDonus.Text = "Dönüş Tarihi :";
            // 
            // dateDonus
            // 
            this.dateDonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDonus.Location = new System.Drawing.Point(189, 161);
            this.dateDonus.Margin = new System.Windows.Forms.Padding(4);
            this.dateDonus.Name = "dateDonus";
            this.dateDonus.Size = new System.Drawing.Size(190, 22);
            this.dateDonus.TabIndex = 51;
            // 
            // dateGidis
            // 
            this.dateGidis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateGidis.Location = new System.Drawing.Point(190, 131);
            this.dateGidis.Margin = new System.Windows.Forms.Padding(4);
            this.dateGidis.Name = "dateGidis";
            this.dateGidis.Size = new System.Drawing.Size(190, 22);
            this.dateGidis.TabIndex = 48;
            // 
            // lblGTarih
            // 
            this.lblGTarih.AutoSize = true;
            this.lblGTarih.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGTarih.Location = new System.Drawing.Point(64, 131);
            this.lblGTarih.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGTarih.Name = "lblGTarih";
            this.lblGTarih.Size = new System.Drawing.Size(116, 23);
            this.lblGTarih.TabIndex = 50;
            this.lblGTarih.Text = "Gidiş Tarihi :";
            // 
            // cmbSefer
            // 
            this.cmbSefer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSefer.FormattingEnabled = true;
            this.cmbSefer.Location = new System.Drawing.Point(190, 100);
            this.cmbSefer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbSefer.Name = "cmbSefer";
            this.cmbSefer.Size = new System.Drawing.Size(190, 21);
            this.cmbSefer.TabIndex = 47;
            this.cmbSefer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSefer_MouseClick);
            // 
            // lblSefer
            // 
            this.lblSefer.AutoSize = true;
            this.lblSefer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSefer.Location = new System.Drawing.Point(53, 100);
            this.lblSefer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSefer.Name = "lblSefer";
            this.lblSefer.Size = new System.Drawing.Size(127, 23);
            this.lblSefer.TabIndex = 49;
            this.lblSefer.Text = "Sefer Seçimi :";
            // 
            // btnRezervasyonTip
            // 
            this.btnRezervasyonTip.Location = new System.Drawing.Point(306, 224);
            this.btnRezervasyonTip.Name = "btnRezervasyonTip";
            this.btnRezervasyonTip.Size = new System.Drawing.Size(180, 40);
            this.btnRezervasyonTip.TabIndex = 2;
            this.btnRezervasyonTip.Text = "Devam Et";
            this.btnRezervasyonTip.UseVisualStyleBackColor = true;
            this.btnRezervasyonTip.Click += new System.EventHandler(this.btnRezervasyonTip_Click);
            // 
            // numYolcuSayi
            // 
            this.numYolcuSayi.Location = new System.Drawing.Point(190, 61);
            this.numYolcuSayi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numYolcuSayi.Name = "numYolcuSayi";
            this.numYolcuSayi.Size = new System.Drawing.Size(190, 21);
            this.numYolcuSayi.TabIndex = 1;
            // 
            // lblYolcuSayisi
            // 
            this.lblYolcuSayisi.AutoSize = true;
            this.lblYolcuSayisi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcuSayisi.Location = new System.Drawing.Point(58, 61);
            this.lblYolcuSayisi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYolcuSayisi.Name = "lblYolcuSayisi";
            this.lblYolcuSayisi.Size = new System.Drawing.Size(120, 23);
            this.lblYolcuSayisi.TabIndex = 42;
            this.lblYolcuSayisi.Text = "Yolcu Sayısı :";
            // 
            // lblRTip
            // 
            this.lblRTip.AutoSize = true;
            this.lblRTip.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRTip.Location = new System.Drawing.Point(19, 21);
            this.lblRTip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRTip.Name = "lblRTip";
            this.lblRTip.Size = new System.Drawing.Size(163, 23);
            this.lblRTip.TabIndex = 26;
            this.lblRTip.Text = "Rezervasyon Tipi :";
            // 
            // cmbRTip
            // 
            this.cmbRTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRTip.FormattingEnabled = true;
            this.cmbRTip.Items.AddRange(new object[] {
            "GİDİŞ",
            "GİDİŞ-DÖNÜŞ"});
            this.cmbRTip.Location = new System.Drawing.Point(190, 23);
            this.cmbRTip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbRTip.Name = "cmbRTip";
            this.cmbRTip.Size = new System.Drawing.Size(190, 21);
            this.cmbRTip.TabIndex = 0;
            this.cmbRTip.SelectedIndexChanged += new System.EventHandler(this.cmbRTip_SelectedIndexChanged);
            // 
            // xtraYolcuBilgi
            // 
            this.xtraYolcuBilgi.Controls.Add(this.cmbYolcuTip);
            this.xtraYolcuBilgi.Controls.Add(this.lblYolcuTip);
            this.xtraYolcuBilgi.Controls.Add(this.btnKisiBilgileriEkle);
            this.xtraYolcuBilgi.Controls.Add(this.lblTCKN);
            this.xtraYolcuBilgi.Controls.Add(this.lblSoyad);
            this.xtraYolcuBilgi.Controls.Add(this.txtAd);
            this.xtraYolcuBilgi.Controls.Add(this.lblAd);
            this.xtraYolcuBilgi.Controls.Add(this.txtTCKN);
            this.xtraYolcuBilgi.Controls.Add(this.txtSoyad);
            this.xtraYolcuBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.xtraYolcuBilgi.Name = "xtraYolcuBilgi";
            this.xtraYolcuBilgi.Size = new System.Drawing.Size(489, 267);
            this.xtraYolcuBilgi.Text = "Yolcu Bilgileri";
            // 
            // cmbYolcuTip
            // 
            this.cmbYolcuTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYolcuTip.FormattingEnabled = true;
            this.cmbYolcuTip.Items.AddRange(new object[] {
            "Tam",
            "Öğrenci"});
            this.cmbYolcuTip.Location = new System.Drawing.Point(169, 126);
            this.cmbYolcuTip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbYolcuTip.Name = "cmbYolcuTip";
            this.cmbYolcuTip.Size = new System.Drawing.Size(224, 21);
            this.cmbYolcuTip.TabIndex = 21;
            // 
            // lblYolcuTip
            // 
            this.lblYolcuTip.AutoSize = true;
            this.lblYolcuTip.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcuTip.Location = new System.Drawing.Point(19, 122);
            this.lblYolcuTip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYolcuTip.Name = "lblYolcuTip";
            this.lblYolcuTip.Size = new System.Drawing.Size(100, 23);
            this.lblYolcuTip.TabIndex = 20;
            this.lblYolcuTip.Text = "Bilet Tipi  :";
            // 
            // btnKisiBilgileriEkle
            // 
            this.btnKisiBilgileriEkle.Location = new System.Drawing.Point(274, 221);
            this.btnKisiBilgileriEkle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnKisiBilgileriEkle.Name = "btnKisiBilgileriEkle";
            this.btnKisiBilgileriEkle.Size = new System.Drawing.Size(180, 40);
            this.btnKisiBilgileriEkle.TabIndex = 4;
            this.btnKisiBilgileriEkle.Text = "Devam Et";
            this.btnKisiBilgileriEkle.UseVisualStyleBackColor = true;
            this.btnKisiBilgileriEkle.Click += new System.EventHandler(this.btnKisiBilgileriEkle_Click);
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKN.Location = new System.Drawing.Point(19, 21);
            this.lblTCKN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(99, 23);
            this.lblTCKN.TabIndex = 18;
            this.lblTCKN.Text = "TC Kimlik :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(43, 85);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(74, 23);
            this.lblSoyad.TabIndex = 17;
            this.lblSoyad.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(170, 52);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(224, 21);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(72, 50);
            this.lblAd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(45, 23);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "Ad :";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(169, 23);
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(224, 21);
            this.txtTCKN.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(170, 89);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(224, 21);
            this.txtSoyad.TabIndex = 2;
            // 
            // xtraOdeme
            // 
            this.xtraOdeme.Controls.Add(this.lblPuan);
            this.xtraOdeme.Controls.Add(this.grpHavale);
            this.xtraOdeme.Controls.Add(this.chkPuan);
            this.xtraOdeme.Controls.Add(this.btnTest);
            this.xtraOdeme.Controls.Add(this.grpKK);
            this.xtraOdeme.Controls.Add(this.cmbOdemeTip);
            this.xtraOdeme.Controls.Add(this.lblOdeme);
            this.xtraOdeme.Controls.Add(this.lblOdemeMesaj);
            this.xtraOdeme.Margin = new System.Windows.Forms.Padding(4);
            this.xtraOdeme.Name = "xtraOdeme";
            this.xtraOdeme.Size = new System.Drawing.Size(489, 267);
            this.xtraOdeme.Text = "Ödeme Onayı";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(130, 21);
            this.lblPuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(18, 19);
            this.lblPuan.TabIndex = 46;
            this.lblPuan.Text = "0";
            // 
            // grpHavale
            // 
            this.grpHavale.Controls.Add(this.txtIBANNo);
            this.grpHavale.Controls.Add(this.lblIBAN);
            this.grpHavale.Controls.Add(this.txtSubeAdi);
            this.grpHavale.Controls.Add(this.lblSubeAd);
            this.grpHavale.Controls.Add(this.lblBankaAd);
            this.grpHavale.Controls.Add(this.txtBankaAdi);
            this.grpHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHavale.Location = new System.Drawing.Point(65, 84);
            this.grpHavale.Margin = new System.Windows.Forms.Padding(4);
            this.grpHavale.Name = "grpHavale";
            this.grpHavale.Padding = new System.Windows.Forms.Padding(4);
            this.grpHavale.Size = new System.Drawing.Size(349, 102);
            this.grpHavale.TabIndex = 8;
            this.grpHavale.TabStop = false;
            this.grpHavale.Text = "Havale";
            // 
            // txtIBANNo
            // 
            this.txtIBANNo.Location = new System.Drawing.Point(125, 72);
            this.txtIBANNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIBANNo.Name = "txtIBANNo";
            this.txtIBANNo.Size = new System.Drawing.Size(219, 20);
            this.txtIBANNo.TabIndex = 3;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIBAN.Location = new System.Drawing.Point(11, 73);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(77, 19);
            this.lblIBAN.TabIndex = 10;
            this.lblIBAN.Text = "IBAN No:";
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(125, 44);
            this.txtSubeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(219, 20);
            this.txtSubeAdi.TabIndex = 2;
            // 
            // lblSubeAd
            // 
            this.lblSubeAd.AutoSize = true;
            this.lblSubeAd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubeAd.Location = new System.Drawing.Point(8, 45);
            this.lblSubeAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubeAd.Name = "lblSubeAd";
            this.lblSubeAd.Size = new System.Drawing.Size(80, 19);
            this.lblSubeAd.TabIndex = 6;
            this.lblSubeAd.Text = "Şube Ad :";
            // 
            // lblBankaAd
            // 
            this.lblBankaAd.AutoSize = true;
            this.lblBankaAd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankaAd.Location = new System.Drawing.Point(7, 20);
            this.lblBankaAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankaAd.Name = "lblBankaAd";
            this.lblBankaAd.Size = new System.Drawing.Size(91, 19);
            this.lblBankaAd.TabIndex = 5;
            this.lblBankaAd.Text = "Banka Adı :";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(123, 16);
            this.txtBankaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(219, 20);
            this.txtBankaAdi.TabIndex = 1;
            // 
            // chkPuan
            // 
            this.chkPuan.AutoSize = true;
            this.chkPuan.Location = new System.Drawing.Point(195, 21);
            this.chkPuan.Name = "chkPuan";
            this.chkPuan.Size = new System.Drawing.Size(81, 17);
            this.chkPuan.TabIndex = 45;
            this.chkPuan.Text = "Puan Kullan";
            this.chkPuan.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(305, 223);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(180, 40);
            this.btnTest.TabIndex = 44;
            this.btnTest.Text = "Öde";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // grpKK
            // 
            this.grpKK.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.grpKK.Controls.Add(this.cmbKKAd);
            this.grpKK.Controls.Add(this.lblKKAdi);
            this.grpKK.Controls.Add(this.lblKKNo);
            this.grpKK.Controls.Add(this.txtKKNo);
            this.grpKK.Location = new System.Drawing.Point(65, 84);
            this.grpKK.Margin = new System.Windows.Forms.Padding(4);
            this.grpKK.Name = "grpKK";
            this.grpKK.Padding = new System.Windows.Forms.Padding(4);
            this.grpKK.Size = new System.Drawing.Size(364, 83);
            this.grpKK.TabIndex = 7;
            this.grpKK.TabStop = false;
            this.grpKK.Text = "Kredi Kartı";
            // 
            // cmbKKAd
            // 
            this.cmbKKAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKKAd.FormattingEnabled = true;
            this.cmbKKAd.Items.AddRange(new object[] {
            "MasterCard",
            "VisaCard"});
            this.cmbKKAd.Location = new System.Drawing.Point(128, 48);
            this.cmbKKAd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbKKAd.Name = "cmbKKAd";
            this.cmbKKAd.Size = new System.Drawing.Size(223, 21);
            this.cmbKKAd.TabIndex = 3;
            // 
            // lblKKAdi
            // 
            this.lblKKAdi.AutoSize = true;
            this.lblKKAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKKAdi.Location = new System.Drawing.Point(40, 50);
            this.lblKKAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKKAdi.Name = "lblKKAdi";
            this.lblKKAdi.Size = new System.Drawing.Size(80, 19);
            this.lblKKAdi.TabIndex = 2;
            this.lblKKAdi.Text = "Kart Tipi :";
            // 
            // lblKKNo
            // 
            this.lblKKNo.AutoSize = true;
            this.lblKKNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKKNo.Location = new System.Drawing.Point(2, 21);
            this.lblKKNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKKNo.Name = "lblKKNo";
            this.lblKKNo.Size = new System.Drawing.Size(118, 19);
            this.lblKKNo.TabIndex = 1;
            this.lblKKNo.Text = "Kredi Kartı No :";
            // 
            // txtKKNo
            // 
            this.txtKKNo.Location = new System.Drawing.Point(128, 19);
            this.txtKKNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtKKNo.Name = "txtKKNo";
            this.txtKKNo.Size = new System.Drawing.Size(223, 21);
            this.txtKKNo.TabIndex = 0;
            // 
            // cmbOdemeTip
            // 
            this.cmbOdemeTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTip.FormattingEnabled = true;
            this.cmbOdemeTip.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Havale"});
            this.cmbOdemeTip.Location = new System.Drawing.Point(195, 53);
            this.cmbOdemeTip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbOdemeTip.Name = "cmbOdemeTip";
            this.cmbOdemeTip.Size = new System.Drawing.Size(223, 21);
            this.cmbOdemeTip.TabIndex = 0;
            this.cmbOdemeTip.SelectedValueChanged += new System.EventHandler(this.cmbOdemeTip_SelectedValueChanged);
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeme.Location = new System.Drawing.Point(68, 51);
            this.lblOdeme.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(103, 19);
            this.lblOdeme.TabIndex = 43;
            this.lblOdeme.Text = "Ödeme Tipi :";
            // 
            // lblOdemeMesaj
            // 
            this.lblOdemeMesaj.AutoSize = true;
            this.lblOdemeMesaj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeMesaj.Location = new System.Drawing.Point(68, 21);
            this.lblOdemeMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeMesaj.Name = "lblOdemeMesaj";
            this.lblOdemeMesaj.Size = new System.Drawing.Size(55, 19);
            this.lblOdemeMesaj.TabIndex = 3;
            this.lblOdemeMesaj.Text = "Puan :";
            // 
            // xtraBiletBilgi
            // 
            this.xtraBiletBilgi.Name = "xtraBiletBilgi";
            this.xtraBiletBilgi.Size = new System.Drawing.Size(489, 267);
            this.xtraBiletBilgi.Text = "Bilet Bilgileri";
            // 
            // xtraSefer
            // 
            this.xtraSefer.Controls.Add(this.lblFiyat);
            this.xtraSefer.Controls.Add(this.numFiyat);
            this.xtraSefer.Controls.Add(this.btnSEkle);
            this.xtraSefer.Controls.Add(this.cmbVaris);
            this.xtraSefer.Controls.Add(this.lblKalkis);
            this.xtraSefer.Controls.Add(this.cmbKalkis);
            this.xtraSefer.Controls.Add(this.lblVaris);
            this.xtraSefer.Margin = new System.Windows.Forms.Padding(4);
            this.xtraSefer.Name = "xtraSefer";
            this.xtraSefer.Size = new System.Drawing.Size(489, 267);
            this.xtraSefer.Text = "Sefer Ekle";
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 302);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REZERVASYON VE BİLET SİSTEMİ";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.xtraRezerve.ResumeLayout(false);
            this.xtraRezerve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYolcuSayi)).EndInit();
            this.xtraYolcuBilgi.ResumeLayout(false);
            this.xtraYolcuBilgi.PerformLayout();
            this.xtraOdeme.ResumeLayout(false);
            this.xtraOdeme.PerformLayout();
            this.grpHavale.ResumeLayout(false);
            this.grpHavale.PerformLayout();
            this.grpKK.ResumeLayout(false);
            this.grpKK.PerformLayout();
            this.xtraSefer.ResumeLayout(false);
            this.xtraSefer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.Button btnSEkle;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblVaris;
        private System.Windows.Forms.Label lblKalkis;
        private System.Windows.Forms.Label lblRTip;
        private System.Windows.Forms.ComboBox cmbRTip;
        private System.Windows.Forms.Button btnKisiBilgileriEkle;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblOdemeMesaj;
        private System.Windows.Forms.ComboBox cmbOdemeTip;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.GroupBox grpKK;
        private System.Windows.Forms.Label lblKKAdi;
        private System.Windows.Forms.Label lblKKNo;
        private System.Windows.Forms.TextBox txtKKNo;
        private System.Windows.Forms.GroupBox grpHavale;
        private System.Windows.Forms.TextBox txtIBANNo;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Label lblSubeAd;
        private System.Windows.Forms.Label lblBankaAd;
        private System.Windows.Forms.TextBox txtBankaAdi;
        private System.Windows.Forms.NumericUpDown numYolcuSayi;
        private System.Windows.Forms.Label lblYolcuSayisi;
        private System.Windows.Forms.Button btnRezervasyonTip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbYolcuTip;
        private System.Windows.Forms.Label lblYolcuTip;
        private System.Windows.Forms.Label lblDonus;
        private System.Windows.Forms.DateTimePicker dateDonus;
        private System.Windows.Forms.DateTimePicker dateGidis;
        private System.Windows.Forms.Label lblGTarih;
        private System.Windows.Forms.ComboBox cmbSefer;
        private System.Windows.Forms.Label lblSefer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox chkPuan;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.ComboBox cmbKKAd;
    }
}