using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPHelper
{

    //Used for databinding 

    public class FormattedAddress
    {

        public string AddressAsString { get; set; }

        public FormattedAddress(string address)
        {
            AddressAsString = address;

        }
    }
}
