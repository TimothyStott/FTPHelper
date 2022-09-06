using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FluentFTP;

namespace FTPHelper.FTPclasses
{
    public static class FtpMethods
    {
        public static bool TestConnection(string ipAddress, string user, string pass)
        {
            try
            {
                var conn = new FtpClient(ipAddress, user, pass);
                conn.Connect();
                MessageBox.Show("FTP Connection Successful", "Success");
                return true;
            }
            catch (Exception ex)
            {
                return false;                
            }

        }

    }
}
