using System.Security.Cryptography;
using System.Text;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    internal class AesCryp
    {
        // Claves de cifrado
        public static string IV = "asdfghjklñzxcvbn";                  // 16 caracteres
        public static string Key = "asdfghjklñzxcvbnasdfghjklñzxcvbn"; // 32 caracteres

        // Método para encriptar texto
        public static string Encrypt(string decrypted)
        {
            byte[] textbytes = Encoding.ASCII.GetBytes(decrypted);

            using (AesCryptoServiceProvider encdec = new AesCryptoServiceProvider())
            {
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = Encoding.ASCII.GetBytes(Key);
                encdec.IV = Encoding.ASCII.GetBytes(IV);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                // Cifrador
                ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);

                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                icrypt.Dispose();

                return Convert.ToBase64String(enc);
            }
        }

        // Método para desencriptar texto
        public static string Decrypt(string encrypted)
        {
            byte[] encbytes = Convert.FromBase64String(encrypted);

            using (AesCryptoServiceProvider encdec = new AesCryptoServiceProvider())
            {
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = Encoding.ASCII.GetBytes(Key);
                encdec.IV = Encoding.ASCII.GetBytes(IV);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                // Cifrador
                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return Encoding.ASCII.GetString(dec);
            }
        }
    }
}
