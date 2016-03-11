using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class IPv4Address
    {
        private string _dottedDecimalFormat;

        public int FirstOctet
        {
            get
            {
                return int.Parse(_dottedDecimalFormat.Split('.')[0]);
            }
        }

        public int SecondOctet
        {
            get
            {
                return int.Parse(_dottedDecimalFormat.Split('.')[1]);
            }
        }

        public int ThirdOctet
        {
            get
            {
                return int.Parse(_dottedDecimalFormat.Split('.')[2]);
            }
        }

        public int FourthOctet
        {
            get
            {
                return int.Parse(_dottedDecimalFormat.Split('.')[3]);
            }
        }

        public IPv4Address(string dottedDecimalFormat)
        {
            _dottedDecimalFormat = dottedDecimalFormat;
        }

        public override string ToString()
        {
            return _dottedDecimalFormat;
        }
    }
}
