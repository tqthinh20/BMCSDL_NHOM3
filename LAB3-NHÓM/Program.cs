using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using _20127337;

public class HASH
{
    public static byte[] HashSHA1(string password)
    {
        using (HashAlgorithm algorithm = SHA1.Create())
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}

public class RSA
{
    public static void RSAPersistKeyInCSP(string ContainerName)
    {
        CspParameters cspParams = new CspParameters();

        cspParams.KeyContainerName = ContainerName;

        RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider(cspParams);
    }

    public static void RSADeleteKeyInCSP(string ContainerName)
    {
        CspParameters cspParams = new CspParameters();

        cspParams.KeyContainerName = ContainerName;

        RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider(cspParams);

        RSAalg.PersistKeyInCsp = false;

        RSAalg.Clear();
    }

    static public byte[] Encrypt(byte[] DataToEncrypt, string ContainerName, bool DoOAEPPadding)
    {
        CspParameters cspParams = new CspParameters();

        cspParams.KeyContainerName = ContainerName;

        RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider(cspParams);

        return RSAalg.Encrypt(DataToEncrypt, DoOAEPPadding);
    }

    static public byte[] Decrypt(byte[] DataToDecrypt, string ContainerName, bool DoOAEPPadding)
    {
        CspParameters cspParams = new CspParameters();

        cspParams.KeyContainerName = ContainerName;

        RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider(cspParams);

        return RSAalg.Decrypt(DataToDecrypt, DoOAEPPadding);
    }
}

public class AES
{
    public static byte[] AddPkcs7Padding(byte[] data, int paddingLength)
    {
        if (data.Length >= 32)
        {
            throw new ArgumentOutOfRangeException("data", "data must be < 32 byte in length to use this function");
        }
        if (paddingLength > 32)
        {
            throw new ArgumentOutOfRangeException("paddingLength", "paddingLength must be <= 32 byte");
        }

        if (paddingLength <= data.Length)
        {
            return data;
        }

        var padded = new byte[paddingLength];
        Buffer.BlockCopy(data, 0, padded, 0, data.Length);
        for (var i = data.Length; i < padded.Length; i++)
        {
            padded[i] = (byte)(paddingLength - data.Length);
        }
        return padded;
    }

    public static byte[] Encrypt(string plainText, string Key)
    {
        if (plainText == null || plainText.Length <= 0)
            throw new ArgumentNullException("plainText");
        if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");

        byte[] encrypted;
        byte[] iv = new byte[16];

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = AddPkcs7Padding(Encoding.UTF8.GetBytes(Key), 32);
            aesAlg.IV = iv;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }

        return encrypted;
    }


    public static string Decrypt(byte[] cipherText, string Key)
    {
        if (cipherText == null || cipherText.Length <= 0)
            throw new ArgumentNullException("cipherText");
        if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");

        string plaintext = null;
        byte[] iv = new byte[16];

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = AddPkcs7Padding(Encoding.UTF8.GetBytes(Key), 32);
            aesAlg.IV = iv;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        return plaintext;
    }
}

static class Nhanvien_NV
{
    private static string _manv = "";

    public static string MANV
    {
        get { return _manv; }
        set { _manv = value; }
    }

    private static string _pubkey = "";

    public static string PUBLICKEY
    {
        get { return _pubkey; }
        set { _pubkey = value; }
    }
}

namespace LAB3_NHÓM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DSNV());
        }
    }
}
