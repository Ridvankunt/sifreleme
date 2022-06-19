using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO;

namespace sezar
{
    public partial class frmSifreCoz : Form
    {
        public frmSifreCoz()
        {
            InitializeComponent();
        }

        //Türkçe alfabe char türünde bir arrayliste atandı
        public static char[] alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
        //Rakamlar char türünde bir arrayliste atandı
        public static char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkOffsetDegeriBiliniyormu.Checked == false) //Eğer checkboxın değeri false ise (Kullanıcı offset değerini biliyorsa) Bu koşul sağlanacak
            {
                txtMetin.Clear(); //Butona her tıklandığında txtSifreliMetin isimli textbox ın içi temizlendi

                if (txtOffset.Text == "") //Eğer Offset değeri girilmemişse kullanıcıdan offset değerinin girilmesi istendi. Böylece oluşabilecek hataların önüne geçildi.
                {
                    MessageBox.Show("Lütfen offset değerini girin.");
                }
                else if (txtSifreliMetin.Text == "") // Eğer şifrelenecek olan metin girilmemişse kullanıcıdan metnin girilmesi istendi. Böylece oluşabilecek hataların önüne geçildi.
                {
                    MessageBox.Show("Lütfen şifreli metni girin.");
                }
                else
                {
                    int offset = Convert.ToInt32(txtOffset.Text); //kullanıcıdan offset değeri alındı
                    string sifreliMetin = txtSifreliMetin.Text; //Kullanıcıdan şifreli metin alındı

                    decryption(offset, sifreliMetin); //Kullancıdan alınan değerler decryption isimli metoda parametre olarak gönderildi.
                }
            }
            else if (chkOffsetDegeriBiliniyormu.Checked == true) // Eğer checkbox ın değeri true ise (Kullanıcı offset değerini bilmiyorsa) bu koşul sağlanacak
            {
                //TDK veritabanında arat
                int offset = 0;
                
                while (true) //Bu while döngüsü sonsuza kadar dönecek
                {
                    string getKelimeDetay = new WebClient().DownloadString("https://sozluk.gov.tr/gts?ara=" + txtMetin.Text + ""); // O anki çözülen metin tdk nın veritabanında aratılacak.
                    if (getKelimeDetay.Contains("error")) // Eğer tdk nın veritabanında yoksa (tdk dan dönen verinin içerisinde error kelimesi varsa) bu koşul sağlanacak
                    {
                        txtMetin.Clear(); // Her seferinde txtMetin isim textbox ın içi temizlenecek. Böylece bir önceki anlamsız veri silinmiş olacak.
                        decryption(offset, txtSifreliMetin.Text); //O anki offset değerine göre şifreli metin çözülmeye çalışılacak
                        offset += 1; //Offset değeri 1 arttırılacak. Böylece tdk veritabanında bir önceki kelime bulunamaz ise, sonraki offset değerine göre şifresi çözülen metin tdk veritabanında aratılmış olacak
                    }
                    else // Eğer tdk nın apisinden dönen değerin içerisinde error kelimesi yoksa ( tdk veritabanında öyle bir kelime varsa ) bu koşul çaışacak
                    {
                        MessageBox.Show("Şifre çözüldü"); // Kullanıcıya şifrenin çözüldüğüne dair mesaj verecek
                        break; // Son olarak döngü kırılıp sonlandırılacak..
                    }
                }

                
            }
        }

        private void chkOffsetDegeriBiliniyormu_CheckedChanged(object sender, EventArgs e) // chkOffsetDegeriBiliniyormu isimli checkbox aracının ChckedChanced isimli eventi
        {
            if (chkOffsetDegeriBiliniyormu.Checked == true)
            {
                txtOffset.Enabled = false;
                txtOffset.Clear();
            }
            else if (chkOffsetDegeriBiliniyormu.Checked == false)
            {
                txtOffset.Enabled = true;
            }
        }

        public void decryption(int offset, string sifreliMetin) // decryption isminde geri dönüş değeri olmayan parametreli method oluşturuldu
        {
            char temp;
            if (offset > 29) //Eğer deneme yanılma yoluyla arttıtılan offset değerleri 29'u geçerse bu koşul sağlanacak
            {
                MessageBox.Show("Kelime bulunamadı!");
            }
            else
            {
                foreach (char c in sifreliMetin.ToLower())
                {
                    temp = c;
                    if (alfabe.Contains(c))
                    {
                        for (int i = 0; i < 28; i++)
                        {
                            if (c == alfabe[i])
                            {
                                temp = alfabe[(i - offset) % 29];
                            }
                        }
                    }
                    else if (rakamlar.Contains(c))
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (c == rakamlar[i])
                            {
                                temp = rakamlar[(i - offset) % 10];
                            }
                        }
                    }

                    txtMetin.Text += temp;
                }
            }
        }
    }
}
