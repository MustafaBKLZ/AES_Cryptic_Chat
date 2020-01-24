using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Cryptic_Chat
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)   
        {
            // Şifreli mesajlaşmayı sağlayan keyleri üretecek olan kodlarımızı class içerisine aldık.
            // keyleri classta ürettikten sonta public değişkenler ile ana forma getirdik.
            ECDiffieHellmanCng_Class.KeyUret();
            txt_Baslatma_Vektoru_IV.Text = ECDiffieHellmanCng_Class.txt_Ortak_Anahtar;
            txt_Kul_1_Public_Key.Text = ECDiffieHellmanCng_Class.txt_Kul_1_Public_Key;
            txt_Kul_2_Public_Key.Text = ECDiffieHellmanCng_Class.txt_Kul_2_Public_Key;

        }
        private void btn_kul1_Click(object sender, EventArgs e)
        {
            Kullanici_1_Ekran fr = new Kullanici_1_Ekran();
            fr.Show();
        }

        private void btn_kul2_Click(object sender, EventArgs e)
        {
            Kullanici_2_Ekran fr = new Kullanici_2_Ekran();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TekFormdaGoster fr = new TekFormdaGoster();
            fr.ShowDialog();
        }
    }
}
