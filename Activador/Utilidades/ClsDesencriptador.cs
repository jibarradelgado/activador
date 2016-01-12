﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Activador.Utilidades
{
    class ClsDesencriptador
    {
        /// <summary>
        /// Desencripta la cadena dada
        /// </summary>
        /// <param name="cipherText">Cadena a desencriptar</param>
        /// <param name="passPhrase">ejemplo Utilize la cadena: "Pas5pr@se"</param>
        /// <param name="saltValue">ejemplo Utilize la cadena: "s@1tValue"</param>
        /// <param name="hashAlgorithm">ejemplo Utilize la cadena: "SHA1"</param>
        /// <param name="passwordIterations">ejemplo Utilice el Valor: 2</param>
        /// <param name="initVector">ejemplo Utilize la cadena: "@1B2c3D4e5F6g7H8"</param>
        /// <param name="keySize">ejemplo Utilice el Valor: 256</param>
        /// <returns></returns>
        public static string Decrypt(string cipherText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

            return plainText;
        }

    }
}
