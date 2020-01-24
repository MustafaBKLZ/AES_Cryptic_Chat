using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AES_Cryptic_Chat
{
    public class ECDiffieHellmanCng_Class
    {

        public static byte[] kullanici_1_Pulic_Key, kullanici_2_Pulic_Key;
        public static byte[] ortak_Anahtar;
        public static byte[] baslatma_Vektoru_IV;


        public static string txt_Kul_1_Public_Key = "";
        public static string txt_Kul_2_Public_Key = "";
        public static string txt_Ortak_Anahtar = "";

        public static void KeyUret()
        {
            
            using (ECDiffieHellmanCng ecd1 = new ECDiffieHellmanCng())
            {
                ecd1.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                ecd1.HashAlgorithm = CngAlgorithm.Sha256;
                kullanici_1_Pulic_Key = ecd1.PublicKey.ToByteArray();
                txt_Kul_1_Public_Key = Convert.ToBase64String(kullanici_1_Pulic_Key);

                using (ECDiffieHellmanCng ecd2 = new ECDiffieHellmanCng())
                {
                    ecd2.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                    ecd2.HashAlgorithm = CngAlgorithm.Sha256;

                    kullanici_2_Pulic_Key = ecd2.PublicKey.ToByteArray();
                    txt_Kul_2_Public_Key = Convert.ToBase64String(kullanici_2_Pulic_Key);

                    ortak_Anahtar = ecd2.DeriveKeyMaterial(CngKey.Import(kullanici_1_Pulic_Key, CngKeyBlobFormat.EccPublicBlob));
                    txt_Ortak_Anahtar = Convert.ToBase64String(ortak_Anahtar);

                }
            }
        }
    }
}
