// Decompiled with JetBrains decompiler
// Type: Roblox.KeyGenerator.Program
// Assembly: Roblox.KeyGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

using Roblox.KeyGenerator.Properties;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

#nullable disable
namespace Roblox.KeyGenerator
{
    internal class Program
    {
        private const int PKCS_RSA_PRIVATE_KEY = 43;
        private const int PKCS_7_ASN_ENCODING = 65536;

        [DllImport("crypt32.dll", SetLastError = true)]
        private static extern bool CryptEncodeObject(
          int dwCertEncodingType,
          int lpszStructType,
          byte[] pvStructInfo,
          byte[] pbEncoded,
          ref int pcbEncoded);

        private static void Main()
        {
            RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(1024);
            byte[] numArray1 = cryptoServiceProvider.ExportCspBlob(true);
            byte[] numArray2 = cryptoServiceProvider.ExportCspBlob(false);
            cryptoServiceProvider.Dispose();
            if (Settings.Default.GenerateBlobs)
            {
                bool base64EncodedBlobs = Settings.Default.Base64EncodedBlobs;
                File.WriteAllText(Settings.Default.PublicKeyBlobFileName, base64EncodedBlobs ? Convert.ToBase64String(numArray2) : Encoding.Default.GetString(numArray2));
                File.WriteAllText(Settings.Default.PrivateKeyBlobFileName, base64EncodedBlobs ? Convert.ToBase64String(numArray1) : Encoding.Default.GetString(numArray1));
            }
            if (!Settings.Default.GeneratePem)
                return;
            int pcbEncoded = 0;
            if (!Program.CryptEncodeObject(65536, 43, numArray1, (byte[])null, ref pcbEncoded))
            {
                Console.WriteLine("CryptEncodeObject failed because \"{0}\"", (object)Marshal.GetLastWin32Error());
                Console.ReadKey();
            }
            else
            {
                byte[] numArray3 = new byte[pcbEncoded];
                if (!Program.CryptEncodeObject(65536, 43, numArray1, numArray3, ref pcbEncoded))
                {
                    Console.WriteLine("CryptEncodeObject failed because \"{0}\"", (object)Marshal.GetLastWin32Error());
                    Console.ReadKey();
                }
                else
                    File.WriteAllText(Settings.Default.PrivateKeyPemFileName, "-----BEGIN RSA PRIVATE KEY-----\r\n" + Convert.ToBase64String(numArray3) + "\r\n-----END RSA PRIVATE KEY-----\r\n");
            }
        }
    }
}