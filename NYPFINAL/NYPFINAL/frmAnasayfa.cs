using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPFINAL
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        //Gidis ve GidisDonus nesnelerini kullanmak için oluşturdum.
        Gidis gidis=new Gidis(); GidisDonus gidisdonus=new GidisDonus();
        //Yolcular ve biletleri tutuluyor.
        Yolcular yolcular = new Yolcular();
        //Yolcu bilgilerini almak için oluşturdum.Puan ve biletleri tutuyor.
        Yolcu yolcu;

       
        //Tüm hatların bilgileri
        Hatlar HatListesi = new Hatlar();
        
        //Seferler Ekleniyor.
        private void cmbSefer_MouseClick(object sender, MouseEventArgs e)
        {
            //Combobox'a seferleri atıyorum.          
            cmbSefer.Items.Clear();
            foreach (var eleman in HatListesi.HatList)
            {
                cmbSefer.Items.Add(eleman.No + " " + eleman.Sefer);

            }
        }

        //REZERVASYON KISIM KODLARI-1
        private void btnRezervasyonTip_Click(object sender, EventArgs e)
        {
            if (cmbSefer.Text == "" || cmbRTip.Text == "" || numYolcuSayi.Value == 0)
            {
                MessageBox.Show("Bilgileri Kontrol Ediniz","BOŞ ALAN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            tabControl.SelectedTabPageIndex = 1;
        }

        //YOLCU BİLGİ EKLEME-2
        private void btnKisiBilgileriEkle_Click(object sender, EventArgs e)
        {
            lblPuan.Text = "0";

            if (cmbYolcuTip.Text==""||txtAd.Text==""||txtSoyad.Text==""||txtTCKN.Text=="")
            {
                MessageBox.Show(" Bilgileri Kontrol ediniz", "BOŞ ALAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Kişinin puanlarını getiriyor.
                foreach (var yolcus in yolcular.YolcuListe)
                {
                    if (yolcus.TCKN == txtTCKN.Text)
                     
                          Puan = yolcus.Puan;
                    lblPuan.Text = Puan.ToString();
                  
                }
                tabControl.SelectedTabPageIndex = 2;
            }
            
           
        }
        decimal Puan = 0;
        decimal PuanKullan = 0;
        

        //Liskov Yöntemi. Rezerve işlemleri gerçekleştiriliyor.
        public bool RezerveKayit(Rezervasyon rezerve)
        {
            bool r=false;
            //Sefer numaralarını alıyor.
            string[] dizi = cmbSefer.Text.Split(' ');
            //Rezervasyon sınıfından kalıtılan Gidis sınıfının başlatıcını kullanarak değerleri atıyoruz.
            if(rezerve is Gidis)
            {
               
               gidis=new Gidis { Hat = HatListesi.SeferBul(Convert.ToInt32(dizi[0].ToString())), TarihGidis = dateGidis.Value, YolcuSayi = (int)(numYolcuSayi.Value) };
               //Gidis sınıfı tarafından ezilen ucrethesapla eziyoruz.
               gidis.Ucret = gidis.UcretHesapla();
               MessageBox.Show("Gidiş Rezervasyon Ücreti: " + gidis.Ucret, "REZERVASYON ÜCRETİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
             r=true;
            }
            else if(rezerve is GidisDonus)
            {
                gidisdonus = (GidisDonus)rezerve;
                //Gidis sınıfına değerleri atıyoruz.
                gidisdonus = new GidisDonus();
                gidisdonus.Hat = HatListesi.SeferBul(Convert.ToInt32(dizi[0]));
                gidisdonus.TarihGidis = dateGidis.Value;
                gidisdonus.TarihDonus = dateGidis.Value;
                gidisdonus.YolcuSayi = (int)numYolcuSayi.Value;
                gidisdonus.Ucret = gidisdonus.UcretHesapla();
                MessageBox.Show("Gidiş Dönüş Rezervasyon Ucret: " + gidisdonus.Ucret, "REZERVASYON ÜCRETİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                r=false;
            }
            return r;
         }
        //Liskov Yöntemi.BiletRezerve işlemleri gerçekleştiriliyor.
        public void BiletRezerveGonder(Bilet bilet,bool r)
        {
            
            //Tam  sınıfının içindeki rezervasyon bilgisine rezervasyon sınıfından kalıtılan gidis nesnesi atanıyor.
            //Agregation Kullanımı
            bilet.Rezervasyon = new Rezervasyon();
            if(r==true)
            {
                bilet.Rezervasyon = gidis;
                //Tam sınıfındaki BiletHesapla fonksiyonu çalıştırılıyor.
                bilet.BiletHesapla(gidis.Ucret);
                //Tam sınıfındaki bilet ücretini yolcu sınıfındaki puana gönderiyorum.
                yolcu.Puan = bilet.Ucret;
                //Agregation Kullanım
                yolcu.BiletList = new List<Bilet>();
                yolcu.BiletEkle(bilet);
               
                MessageBox.Show("Tam Bilet Ucret: " + bilet.Ucret, "BİLET ÜCRET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yolcu.Puan = bilet.Ucret / 1000;
              
            }
            else if(r==false)
            {
                bilet.Rezervasyon = gidisdonus;
                //Tam sınıfındaki BiletHesapla fonksiyonu çalıştırılıyor.
                bilet.BiletHesapla(gidisdonus.Ucret);
                //Tam sınıfındaki bilet ücretini yolcu sınıfındaki puana gönderiyorum.
                yolcu.Puan = bilet.Ucret;
                //Agregation Kullanım
                yolcu.BiletList = new List<Bilet>();
                yolcu.BiletEkle(bilet);
                
                MessageBox.Show("Tam Bilet Ucret: " + bilet.Ucret, "BİLET ÜCRET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yolcu.Puan = bilet.Ucret / 1000;
               
            }
            
        }     

        private void btnTest_Click(object sender, EventArgs e)
        {
           //Bilet tipleri olan t ve o nesnelerini kullanıcaz. Ve bu nesnelere parametre olarak 1-1000 arasında bir deger atıyoruz.
            Random rast = new Random();
            Tam t = new Tam(rast.Next(1,1000));
            Ogrenci o = new Ogrenci(rast.Next(1,1000));
            
            if(cmbOdemeTip.Text=="")
            {
                MessageBox.Show("Lütfen Ödeme İşlemlerini Yapınız");
                return;
            }


            if (MessageBox.Show("BİLET İŞLEMİNİ ONAYLIYOR MUSUNUZ?","BİLET ONAYLAMA",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes )
            {
            //Puan kullanılmak istenirse...
            if (chkPuan.Checked == true)
            {
                foreach (var yolcus in yolcular.YolcuListe)
                {
                    if (txtTCKN.Text == yolcus.TCKN)
                    {
                        PuanKullan = Puan;
                        yolcus.Puan = 0;
                        lblPuan.Text = "0";
                    }
                }
            }

            bool r;
            //REZERVASYON TİPİ SEÇİMİ (0=>GİDİŞ)
            if (cmbRTip.SelectedIndex == 0)
            {

                r=RezerveKayit(gidis);
                //Bilgileri nesne başlatıcı ile alıyoruz.
                yolcu = new Yolcu { Ad = txtAd.Text, Soyad = txtSoyad.Text, TCKN = txtTCKN.Text, };
                //YOLCU TİPİ SEÇİMİ İÇİN(0=>TAM)        
                 if (cmbYolcuTip.SelectedIndex == 0)
                {
                    //TamBilet sınıfının içindeki rezervasyon bilgisine rezervasyon sınıfından kalıtılan gidis nesnesi atanıyor.
                    BiletRezerveGonder(t,r);
                }
                //YOLCU TİPİ SEÇİMİ İÇİN(1=>ÖĞRENCİ)
                else if (cmbYolcuTip.SelectedIndex == 1)
                {
                    //ÖğrenciBilet sınıfının içindeki rezervasyon bilgisine rezervasyon sınıfından kalıtılan gidis nesnesi atanıyor.
                    BiletRezerveGonder(o,r);
                }
            }
            //REZERVASYON TİP SEÇİMİ (1=>GİDİŞ-DÖNÜŞ)
            else if (cmbRTip.SelectedIndex == 1)
            {
                r=RezerveKayit(gidisdonus);
                //Bilgileri başlatıcı ile alıyoruz.
                yolcu = new Yolcu { Ad = txtAd.Text, Soyad = txtSoyad.Text, TCKN = txtTCKN.Text };
                //YOLCU TİPİ İÇİN(0=>TAM)
                if (cmbYolcuTip.SelectedIndex == 0)
                {
                    //tam sınıfının içindeki rezervasyon bilgisine, rezervasyon sınıfından kalıtılan gidisdonus nesnesi atanıyor.
                    BiletRezerveGonder(t,r);

                }
                //YOLCU TİPİ İÇİN (1=>ÖĞRENCİ)
                else if (cmbYolcuTip.SelectedIndex == 1)
                {
                    //o sınıfının içindeki rezervasyon bilgisine, rezervasyon sınıfından kalıtılan gidisdonus nesnesi atanıyor.
                    BiletRezerveGonder(o,r);
                    
                }
            }
        
                  
            
            //combobox ödeme tipi kredi kartı ise
            if (cmbOdemeTip.SelectedIndex == 0)
            {
                KrediKart kk = new KrediKart();
                kk.KKAdi = cmbKKAd.Text;
                kk.KKNo = txtKKNo.Text;
                if(cmbYolcuTip.SelectedIndex==0)
                {
                    kk.Odenilen = t.Ucret - PuanKullan;
                }
                else if(cmbYolcuTip.SelectedIndex==1)
                {
                    kk.Odenilen = o.Ucret - PuanKullan;
                }
                
                if (cmbRTip.SelectedIndex == 0)
                {
                    gidis.Odeme = kk;
                }
                else if (cmbRTip.SelectedIndex == 1)
                {
                    gidisdonus.Odeme = kk;
                }

            }
            //combobox ödeme tipi havale ise
            else if (cmbOdemeTip.SelectedIndex == 1)
            {

                Havale hav = new Havale();
                hav.BankaAdi = txtBankaAdi.Text;
                hav.SubeAdi = txtSubeAdi.Text;
                hav.IBANNo = txtIBANNo.Text;
                if (cmbYolcuTip.SelectedIndex == 0)
                {
                    hav.Odenilen = t.Ucret - PuanKullan;
                }
                else if (cmbYolcuTip.SelectedIndex == 1)
                {
                    hav.Odenilen = o.Ucret - PuanKullan;
                }
                if (cmbRTip.SelectedIndex == 0)
                {
                    gidis.Odeme = hav;
                }
                else if (cmbRTip.SelectedIndex == 1)
                {
                    gidisdonus = new GidisDonus();
                    gidisdonus.Odeme = hav;
                }
            }


            bool d = false;
            //Yolcu varsa yolcunun biletini yolcuya ekliyeceğiz, yoksa yolcuyu listeye ekliyeceğiz.
            if (yolcular.YolcuListe.Count() != 0)
            {
                foreach (var eleman in yolcular.YolcuListe.ToList())
                {
                   
                    if (eleman.TCKN == yolcu.TCKN)
                    {
                        eleman.Puan += yolcu.Puan;
                       
                        if (cmbYolcuTip.SelectedIndex == 0)
                        {

                            eleman.BiletList.Add(t);
                            break;
                         
                        }
                        else
                        {
                            eleman.BiletList.Add(o);
                            break;
                        }
                        
                    }
                    else
                    {
                        d = true;
                        
                    }
                    
                }
            }
            else
            {
               
                yolcular.Ekle(yolcu);
            }
           
            if(d==true)
            {
                yolcular.Ekle(yolcu);
               
            }

            MessageBox.Show("BİLETİNİZ HAZIRLANMIŞTIR\n"+yolcu.BilgiGoster(),"BİLET BİLGİLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            NesneTemizle();
            tabControl.SelectedTabPageIndex = 0;
            }
            else
            {
                MessageBox.Show("Bilet Hazırlama İşlemi Gerçekleştirilmedi","BİLET İPTAL",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
       
        }

        //Yeni Hat Ekleme
        private void btnSEkle_Click(object sender, EventArgs e)
        {
                   
            
            Random r = new Random();
            //Hat No üyesine rastgele değer atıyoruz parametre alan constroctorla
            Hat hat = new Hat(r.Next(1,1000)); 
            //Hangi seferler olduğunu comboboxlardan alıyoruz.
            hat.Sefer = cmbKalkis.Text + "-" + cmbVaris.Text;
            //Fiyat
            hat.Fiyat = Convert.ToDecimal(numFiyat.Value);
            //Yukarıda oluşturduğumuz hatlistesine atıyoruz.
            HatListesi.Ekle(hat);
            MessageBox.Show("Sefer başarıyla eklendi");
        }
        //Ödeme Tipleri ile ilgili işlemler
        private void cmbOdemeTip_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTip.Text == "Kredi Kartı")
            {
                grpKK.Visible = true;
                grpHavale.Visible = false;
            }
            else if (cmbOdemeTip.Text == "Havale")
            {
                grpHavale.Visible = true;
                grpKK.Visible = false;
                grpHavale.Location = new Point(67, 84);
            }
        }


        //GİDİŞ-DÖNÜŞ Seçiminde Dönüş tarihi için olan dateDonus nesnesinin etkinleştirlmesi.-3
        private void cmbRTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRTip.SelectedIndex == 0)
            {
                dateDonus.Enabled = false;
            }
            else if (cmbRTip.SelectedIndex == 1)
            {
                dateDonus.Enabled = true;
            }
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            grpHavale.Visible = false;
            grpKK.Visible = false;

        }

       private void NesneTemizle()
        {
           
           foreach (Control kontrl in this.Controls)
           {
               if(kontrl is TextBox)
               {
                   TextBox txtbox = (TextBox)kontrl;
                       txtbox.Text="";
               }
               else if(kontrl is NumericUpDown)
               {
                   NumericUpDown num = (NumericUpDown)kontrl;
                   num.Value = 0;
               }
               
           }
        }

     

      
        
    }
    
}

