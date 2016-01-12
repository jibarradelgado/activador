using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Activador.Utilidades
{
    public class ClsEncriptador
    {
        /// <summary>
        /// Encripta la cadena dada 
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="passPhrase">ejemplo Utilize la cadena: "Pas5pr@se"</param>
        /// <param name="saltValue">ejemplo Utilize la cadena: "s@1tValue"</param>
        /// <param name="hashAlgorithm">ejemplo Utilize la cadena: "SHA1"</param>
        /// <param name="passwordIterations">ejemplo Utilice el Valor: 2</param>
        /// <param name="initVector">ejemplo Utilize la cadena: "@1B2c3D4e5F6g7H8"</param>
        /// <param name="keySize">ejemplo Utilice el Valor: 256</param>
        /// <returns></returns>      
        public static string Encrypt(string plainText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string cipherText = Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }
    }
}
