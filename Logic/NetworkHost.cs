using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NetworkHost
    {
        public IPv4Address IPAddress
        {
            get;
            private set;
        }

        public IPv4Address SubnetMask
        {
            get;
            private set;
        }

        public IPv4Address NetworkID
        {
            get
            {
                return new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                    this.IPAddress.FirstOctet & this.SubnetMask.FirstOctet,
                    this.IPAddress.SecondOctet & this.SubnetMask.SecondOctet,
                    this.IPAddress.ThirdOctet & this.SubnetMask.ThirdOctet,
                    this.IPAddress.FourthOctet & this.SubnetMask.FourthOctet));
            }
        }

        public NetworkHost(IPv4Address ipAddress, IPv4Address subnetMask)
        {
            this.IPAddress = ipAddress;
            this.SubnetMask = subnetMask;
        }
    }
}
