using System;
using System.Security.Cryptography;
using System.Text; 
using System.IO;

namespace RSAEncryptDecrypt
{
  class RSAEncryptDecrypt
  {
    static string CIPHERTEXT = @"C:\Users\Megan Vest\Desktop\CIS405 Misc\Assignments\Asymmetric\VestCipherText.txt";
    static string RSAPUBLICKEY = @"C:\Users\Megan Vest\Desktop\CIS405 Misc\Assignments\Asymmetric\StudentPublicOnlyKey.xml";
    static string RSAPUBLICPRIVATEKEY = @"C:\Users\Megan Vest\Desktop\CIS405 Misc\Assignments\Asymmetric\StudentPublicPrivateKey.xml";

    static void Main(string[] args)
    {
      Encrypt();
      Decrypt();
    }

    static void Encrypt()
    {
        //Student encypt their SS number
        byte[] plainText = Encoding.UTF8.GetBytes("S00511653");

        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

      // get public RSA key 
      StreamReader reader = new StreamReader(RSAPUBLICKEY);
      string RSAPublicOnlyKeyXML = reader.ReadToEnd();
      reader.Close();

        // encrypt using RSA public key
        rsa.FromXmlString(RSAPublicOnlyKeyXML);
      byte[] cipherTextEncrypted = rsa.Encrypt(plainText, true);

        FileStream fout = File.Create(CIPHERTEXT);

        fout.Write(cipherTextEncrypted, 0, cipherTextEncrypted.Length);
        fout.Close();
    }
  
    static void Decrypt()
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

      //read public and privateRSA parameters for encrypt
      StreamReader reader = new StreamReader(RSAPUBLICPRIVATEKEY);
      string RSAPublicPrivateKeyXML = reader.ReadToEnd();
      reader.Close();

        //read encrypted file and store in byte array  
        FileStream fin = File.OpenRead(CIPHERTEXT);
        byte[] cipherBytes = new byte[fin.Length];
        fin.Read(cipherBytes, 0, cipherBytes.Length);
        fin.Close();

        //decrypt byte array using OAEP padding
        // decrypt cipherbytes and store into byte array newPlainText
        rsa.FromXmlString(RSAPublicPrivateKeyXML);
      byte[] newPlainText = rsa.Decrypt(cipherBytes, true);
        Console.WriteLine(Encoding.UTF8.GetString(newPlainText));
        Console.WriteLine("Hit any key to continue ");
        Console.ReadLine();
    }
  }
}



