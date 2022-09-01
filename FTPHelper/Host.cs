using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FTPHelper
{
    public class Host
    {
        private string hostAddress => Dns.GetHostName();
        private IPHostEntry ipEntry => Dns.GetHostEntry(hostAddress);

        //returns only IPV4 Addresses
        private IPAddress[] ipv4addresses = Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);
        public string Name => hostAddress.ToString();

        public string[] addresses;
        public ObservableCollection<FormattedAddress> Addresses => GetListViewableAddresses(addresses);


        public Host()
        {
            addresses = GetAddressesAsString(this.ipv4addresses);
        }

        //formats IPs as strings to then format as an observable collection
        private string[] GetAddressesAsString(IPAddress[] iPAddresses)
        {
            string[] addresses = new string[iPAddresses.Length];
            for (int i = 0; i < iPAddresses.Length; i++)
            {
                string temp = iPAddresses[i].ToString();
                addresses[i] = iPAddresses[i].ToString();
            }
            return addresses;
        }

        //formats IPs from array to Observable Collection for data binding
        private ObservableCollection<FormattedAddress> GetListViewableAddresses(string[] addresses)
        {

            ObservableCollection<FormattedAddress> ips = new ObservableCollection<FormattedAddress>();

            for (int i = 0; i < addresses.Length; i++)
            {
                string temp = addresses[i].ToString();
                ips.Add(new FormattedAddress(addresses[i]));
            }
;
            return ips;
        }
        

    }




}
