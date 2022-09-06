using FTPHelper.FTPclasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FTPHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();   
            
        }

        private void testConnectionButton_Click(object sender, RoutedEventArgs e)
        {

            if (FtpMethods.TestConnection(dsIP1.Text.Trim() + "." + dsIP2.Text.Trim() + "." + dsIP3.Text.Trim() + "." + dsIP4.Text.Trim(), userIDTextBox.Text.Trim(), passwordPassBox.ToString().Trim()))
            {
                openConnectionButton.Visibility = Visibility.Visible;
                openConnectionButton.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Connection Failed", "Error");
            }
        }

        private void openPDF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Process pdfOpen = new Process())
                {
                    pdfOpen.StartInfo.UseShellExecute = true;
                    pdfOpen.StartInfo.FileName = "..\\..\\..\\Documents\\setIpHandpad.pdf";
                    pdfOpen.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File not found call Tech Support");
            }
        }

        private void openGoogle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Process openGoogle = new Process())
                {
                    openGoogle.StartInfo.UseShellExecute = true;
                    openGoogle.StartInfo.FileName = @"https://letmegooglethat.com/?q=Set+IPv4+IP+address";
                    openGoogle.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please just google it.");
            }


        }

        private void openConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Process openExplorer = new Process())
                {

                    System.Diagnostics.Process.Start("explorer", @"ftp://ftp.dlptest.com")  ;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please call tech support");
            }


        }
    }
}
