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
    public partial class frmSifrele : Form
    {
        public frmSifrele()
        {
            InitializeComponent();
        }

        //Türkçe alfabe char türünde bir arrayliste atandı
        public static char[] alfabe = { 'a','b','c','ç', 'd','e','f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'};
        //Rakamlar char türünde bir arrayliste atandı
        public static char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private void button1_Click(object sender, EventArgs e)
        {

            txtSifreliMetin.Clear(); //Butona her tıklandığında txtSifreliMetin isimli textbox ın içi temizlendi

            if (txtOffset.Text == "") //Eğer Offset değeri girilmemişse kullanıcıdan offset değerinin girilmesi istendi. Böylece oluşabilecek hataların önüne geçildi.
            {
                MessageBox.Show("Lütfen anahtar kelimeyi girin.");
            }
            else if(txtMetin.Text == "") // Eğer şifrelenecek olan metin girilmemişse kullanıcıdan metnin girilmesi istendi. Böylece oluşabilecek hataların önüne geçildi.
            {
                MessageBox.Show("Lütfen şifrelenecek metni girin.");
            }
            else
            {
                int offset = Convert.ToInt32(txtOffset.Text); //kullanıcıdan offset değeri alındı
                string metin = txtMetin.Text; //Kullanıcıdan şifrelenecek metin alındı

                encryption(offset, metin); // Kullanıcıdan alınan değerler encryption isimli metodun parametrelerine gönderildi.
            }
        }

        public void encryption(int offset, string sifrelenecekMetin) // encryption isminde geri dönüş değeri olmayan paramatreli bir metot tanımlandı
        {
            char temp; //Char türünde temp isimli bir değişken oluşturuldu. Böylece offset değeri arttırılan her harf bu ddeğişkenin içinde tutulacak
            foreach (char c in sifrelenecekMetin.ToLower()) //Kullanıcıdan alınan şifrelenecek metnin karakter sayısı kadar foreach döngüsü dönecek
            {
                temp = c; //Foreach döngüsü her döndüğünde, kullanıcıdan alınan metnin o anki index değerindeki harf, temp değişkenine atanacak
                if (alfabe.Contains(c)) //Eğer o anki karakter, alfabe isimli arraylistin içerisinde varsa bu koşul sağlanacak. 
                {
                    for (int i = 0; i < 28; i++) //alfabe isimli arraylist 0 dan başldığı için bu for döngüsü 28 defa dönecek
                    {
                        if (c == alfabe[i]) //Eğer o anki karakter, alfabe isimli arraylist in o anki indexinin içinde varsa bu koşul sağlanacak
                        {
                            temp = alfabe[(i + offset) % 29]; //temp isimli değişkenin içerisine o anki harfin offset değeri fazlası kadarının mod 29 a göre değerindeki indexdeki harf temp isimli değişkene aktarılacak
                        }
                    }
                }
                else if (rakamlar.Contains(c)) // Eğer o anki karakter, rakamlar isimli arraylistin içerisinde varsa bu koşul sağlanacak
                {
                    for (int i = 0; i < 9; i++) //rakamlar isimli arraylist 0 dan başladığı için bu for döngüsü 10 defa dönecek
                    {
                        if (c == rakamlar[i]) // Eğer o anki karakter, rakamlar isimli arraylistin o anki indexinin (i. index) içinde varsa bu koşul sağlanacak
                        {
                            temp = rakamlar[(i + offset) % 10]; //temp isimli değişkenin içerisinde o anki rakamın offset değeri fazlası kadarının mod 10 a göre değerindeki indexdeki harf temp isimli değişkene aktarılacak
                        }
                    }
                }
                
                txtSifreliMetin.Text += temp; // Son olarak o anki temp değeri txtSifreliMetin isimli textbox ın içine eklenecek
            }
        }
    }
}
