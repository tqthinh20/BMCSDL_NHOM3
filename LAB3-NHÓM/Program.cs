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

public class Encrypt
{
    public static byte[] HashSHA1(string password)
    {
        using (HashAlgorithm algorithm = SHA1.Create())
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}

static class Nhanvien_NV
{
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
