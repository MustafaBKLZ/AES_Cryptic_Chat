using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Cryptic_Chat
{
    public partial class Kullanici_1_Ekran : Form
    {
        public Kullanici_1_Ekran()
        {
            InitializeComponent();
        }

        private void Kullanici_1_Ekran_Load(object sender, EventArgs e)
        {
            // Gelen ve giden mesajları timer ile kontrol edip alacağız.
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btn_Gonder_Kul_1_Click(object sender, EventArgs e)
        {
            // Gönderme sadece buton ile olacak ama geleni alma kısmını timer yapacak.
            // Timer olmaz ise sadece mesaj gönderdiğimizde gelenden haberimiz olur.
            Gonder();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer ile geleni kontrol ediyoruz.
            Al();
        }

        void Gonder()
        {
            string messageToSend = txt_gonderilecek.Text;
            using (Aes aes = new AesCryptoServiceProvider())
            {
                // Classımız da üretilen keyler ile işlemlerimizi yapıyoruz.
                aes.Key = ECDiffieHellmanCng_Class.ortak_Anahtar;
                if (ECDiffieHellmanCng_Class.baslatma_Vektoru_IV == null || ECDiffieHellmanCng_Class.baslatma_Vektoru_IV.Length <= 0)
                    ECDiffieHellmanCng_Class.baslatma_Vektoru_IV = aes.IV;
                else
                    aes.IV = ECDiffieHellmanCng_Class.baslatma_Vektoru_IV;
                ECDiffieHellmanCng_Class.txt_Ortak_Anahtar = Convert.ToBase64String(ECDiffieHellmanCng_Class.baslatma_Vektoru_IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainTextMessage = Encoding.UTF8.GetBytes(messageToSend);
                        cs.Write(plainTextMessage, 0, plainTextMessage.Length);
                        cs.Close();
                        // Sadece göndermek istediğimiz mesajı gönderiyoruz. 
                        // Ekrana gelecek olan bilgiler kullanıcı 2'den gelecek olan bilgilerdir.
                        Chat_Class.Kullanici_1_Mesaj = ms.ToArray();
                    }
                }
            }
        }

        void Al()
        {
            try
            {
                using (Aes aes = new AesCryptoServiceProvider())
                {
                    aes.Key = ECDiffieHellmanCng_Class.ortak_Anahtar;
                    aes.IV = ECDiffieHellmanCng_Class.baslatma_Vektoru_IV;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            // Biz kullanıcı 1'iz 
                            // Kullanıcı 2'den gelen bilgileri ekranımızda gösteriyoruz.
                            // Bu işlemi class kullanarak yaptığımızdan dolayı timer bizim için çok önemlidir.
                            cs.Write(Chat_Class.Kullanici_2_Mesaj, 0, Chat_Class.Kullanici_2_Mesaj.Length);
                            cs.Close();
                            txt_gelen_normal.Text = Encoding.UTF8.GetString(ms.ToArray());
                            txt_gelen_sifreli.Text = Convert.ToBase64String(Chat_Class.Kullanici_2_Mesaj);
                        }
                    }
                }
            }
            // İlk açılışta bu özel durumlar çıktığından dolayı bunları eklemek zorundayız. 
            // Zaten kodların çalışmasında bir sorun yok.
            catch (ArgumentNullException)
            {
            }
            catch (NullReferenceException)
            {
            }

        }


    }
}
