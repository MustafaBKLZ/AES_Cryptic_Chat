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
    public partial class TekFormdaGoster : Form
    {
        public TekFormdaGoster()
        {
            InitializeComponent();
        }
        byte[] person1PublicKey, person2PublicKey;
        byte[] commonKey;
        byte[] IV;
        byte[] encryptedMessage1, encryptedMessage2;
        private void orjinal_Load(object sender, EventArgs e)
        {

        }
        private void GenerateKeys()
        {
            using (ECDiffieHellmanCng ecd1 = new ECDiffieHellmanCng())
            {
                ecd1.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                ecd1.HashAlgorithm = CngAlgorithm.Sha256;
                person1PublicKey = ecd1.PublicKey.ToByteArray();
                txt_Kul_1_Public_Key.Text = Convert.ToBase64String(person1PublicKey);

                /* 2. kişi tarafındaki işlemler, 1. kişinin açık anahtarı biliniyor. */
                using (ECDiffieHellmanCng ecd2 = new ECDiffieHellmanCng())
                {
                    ecd2.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                    ecd2.HashAlgorithm = CngAlgorithm.Sha256;

                    person2PublicKey = ecd2.PublicKey.ToByteArray();
                    txt_Kul_2_Public_Key.Text = Convert.ToBase64String(person2PublicKey);

                    commonKey = ecd2.DeriveKeyMaterial(CngKey.Import(person1PublicKey, CngKeyBlobFormat.EccPublicBlob));
                    txt_Ortak_Anahtar.Text = Convert.ToBase64String(commonKey);

                }
            }
        }

        private void personSendBtn_Click(object sender, EventArgs e)
        {
            bool person1To2 = int.Parse(((Button)sender).Tag.ToString()) == 1;

            string messageToSend = person1To2 ? txt_Giden_Mesaj_Kul_1.Text : txt_Giden_Mesaj_Kul_2.Text;

            if (person1PublicKey == null || person1PublicKey.Length <= 0)
                GenerateKeys();

            // Gönderiliyor

            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = commonKey;

                if (IV == null || IV.Length <= 0)
                    IV = aes.IV;
                else
                    aes.IV = IV;

                ECDiffieHellmanCng_Class.txt_Ortak_Anahtar = Convert.ToBase64String(IV);
                txt_Baslatma_Vektoru_IV.Text = Convert.ToBase64String(IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainTextMessage = Encoding.UTF8.GetBytes(messageToSend);
                        cs.Write(plainTextMessage, 0, plainTextMessage.Length);
                        cs.Close();

                        if (person1To2)
                        {
                            encryptedMessage1 = ms.ToArray();
                            txt_Sifreli_Gelen_Mesaj_kul_2.Text = Convert.ToBase64String(encryptedMessage1);
                        }
                        else
                        {
                            encryptedMessage2 = ms.ToArray();
                            txt_Sifreli_Gelen_Mesaj_kul_1.Text = Convert.ToBase64String(encryptedMessage2);
                        }
                    }
                }
            }

            // Alınıyor

            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = commonKey;
                aes.IV = IV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        if (person1To2)
                            cs.Write(encryptedMessage1, 0, encryptedMessage1.Length);
                        else
                            cs.Write(encryptedMessage2, 0, encryptedMessage2.Length);

                        cs.Close();

                        string receivedMessage = Encoding.UTF8.GetString(ms.ToArray());

                        if (person1To2)
                            txt_Gelen_Mesaj_Kul_2.Text = receivedMessage;
                        else
                            txt_Gelen_Mesaj_Kul_1.Text = receivedMessage;
                    }
                }
            }
        }
    }
}
