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

        public IPv4Address FirstHostAddress
        {
            get
            {
                string lastOctetBinary = NumberLogic.IntToBinary(this.NetworkID.FourthOctet);
                lastOctetBinary = lastOctetBinary.Remove(lastOctetBinary.Length - 1) + "1";

                int lastOctetFirstHost = NumberLogic.BinaryToInt(lastOctetBinary);
                
                return new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                    this.NetworkID.FirstOctet,
                    this.NetworkID.SecondOctet,
                    this.NetworkID.ThirdOctet,
                    lastOctetFirstHost));
            }
        }

        public IPv4Address LastHostAddress
        {
            get
            {
                string lastOctetBinary = NumberLogic.IntToBinary(this.BroadcastAddress.FourthOctet);
                lastOctetBinary = lastOctetBinary.Remove(lastOctetBinary.Length - 1) + "0";

                int lastOctetFirstHost = NumberLogic.BinaryToInt(lastOctetBinary);

                return new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                    this.BroadcastAddress.FirstOctet,
                    this.BroadcastAddress.SecondOctet,
                    this.BroadcastAddress.ThirdOctet,
                    lastOctetFirstHost));
            }
        }

        public IPv4Address BroadcastAddress
        {
            get
            {
                string networkAddressLongBinary = String.Format("{0}{1}{2}{3}",
                    NumberLogic.IntToBinary(this.NetworkID.FirstOctet),
                    NumberLogic.IntToBinary(this.NetworkID.SecondOctet),
                    NumberLogic.IntToBinary(this.NetworkID.ThirdOctet),
                    NumberLogic.IntToBinary(this.NetworkID.FourthOctet));

                string networkPortion = networkAddressLongBinary.Substring(0, this.CIDRMaskLength);

                while(networkPortion.Length < 32)
                {
                    networkPortion += "1";
                }

                return new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                    NumberLogic.BinaryToInt(networkPortion.Substring(0,8)),
                    NumberLogic.BinaryToInt(networkPortion.Substring(8, 8)),
                    NumberLogic.BinaryToInt(networkPortion.Substring(16, 8)),
                    NumberLogic.BinaryToInt(networkPortion.Substring(24, 8))
                    ));
            }
        }

        public IPv4Address NextNetworkID
        {
            get
            {
                IPv4Address nextNetworkID = new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                    this.BroadcastAddress.FirstOctet,
                    this.BroadcastAddress.SecondOctet,
                    this.BroadcastAddress.ThirdOctet,
                    this.BroadcastAddress.FourthOctet + 1));

                if (nextNetworkID.FourthOctet > 255)
                {
                    nextNetworkID = new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                        nextNetworkID.FirstOctet,
                        nextNetworkID.SecondOctet,
                        nextNetworkID.ThirdOctet + 1,
                        0));
                }

                if (nextNetworkID.ThirdOctet > 255)
                {
                    nextNetworkID = new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                        nextNetworkID.FirstOctet,
                        nextNetworkID.SecondOctet + 1,
                        0,
                        0));
                }

                if (nextNetworkID.SecondOctet > 255)
                {
                    nextNetworkID = new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                        nextNetworkID.FirstOctet + 1,
                        0,
                        0,
                        0));
                }

                return nextNetworkID;
            }
        }

        public NetworkHost NextNetwork
        {
            get
            {
                return new NetworkHost(this.NextNetworkID, this.SubnetMask);
            }
        }

        public int CIDRMaskLength
        {
            get
            {
                int result = 0;
                string subnetMaskLongBinary = String.Format("{0}{1}{2}{3}",
                    NumberLogic.IntToBinary(this.SubnetMask.FirstOctet),
                    NumberLogic.IntToBinary(this.SubnetMask.SecondOctet),
                    NumberLogic.IntToBinary(this.SubnetMask.ThirdOctet),
                    NumberLogic.IntToBinary(this.SubnetMask.FourthOctet));

                for (int i = 0; i < subnetMaskLongBinary.Length; i++)
                {
                    result += subnetMaskLongBinary.Substring(i,1) == "1" ? 1 : 0;
                }

                return result;
            }
        }

        public NetworkHost(IPv4Address ipAddress, IPv4Address subnetMask)
        {
            this.IPAddress = ipAddress;
            this.SubnetMask = subnetMask;
        }
    }
}
