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
using LAB3_NHÓM;

public class HASH
{
    public static byte[] HashMD5(string password)
    {
        using (HashAlgorithm algorithm = MD5.Create())
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
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
            Application.Run(new Dangnhap());
        }
    }
}
