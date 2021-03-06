﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace VLSMSAK
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            for (int i = 0; i < 31; i++)
            {
                cmbCIDRMask.Items.Add(i);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            CalculateBinaryForm((TextBox)sender, txtOutputHostIP);
            CreateNetworkHost();
        }

        private void CalculateBinaryForm(TextBox input, TextBox output)
        {
            try
            {
                IPv4Address ipAddress = new IPv4Address(input.Text);

                output.Text = String.Format("{0}.{1}.{2}.{3}",
                    NumberLogic.IntToBinary(ipAddress.FirstOctet),
                    NumberLogic.IntToBinary(ipAddress.SecondOctet),
                    NumberLogic.IntToBinary(ipAddress.ThirdOctet),
                    NumberLogic.IntToBinary(ipAddress.FourthOctet));
            }
            catch (Exception ex) { }
        }

        private void CreateNetworkHost()
        {
            try
            {
                NetworkHost networkHost = new NetworkHost(
                    new IPv4Address(txtInputHostIP.Text),
                    new IPv4Address(txtInputSubnetMask.Text));

                txtNetworkIDDecimal.Text = networkHost.NetworkID.ToString();
                CalculateBinaryForm(txtNetworkIDDecimal, txtNetworkIDBinary);

                txtFirstHostAddressDecimal.Text = networkHost.FirstHostAddress.ToString();
                CalculateBinaryForm(txtFirstHostAddressDecimal, txtFirstHostAddressBinary);

                txtBroadcastAddressDecimal.Text = networkHost.BroadcastAddress.ToString();
                CalculateBinaryForm(txtBroadcastAddressDecimal, txtBroadcastAddressBinary);

                txtLastHostAddressDecimal.Text = networkHost.LastHostAddress.ToString();
                CalculateBinaryForm(txtLastHostAddressDecimal, txtLastHostAddressBinary);

                txtHosts.Text = String.Format("{0}", Math.Pow(2, 32 - Double.Parse(cmbCIDRMask.Text)) - 2);
                txtNetworks.Text = String.Format("{0}", Math.Pow(2, Double.Parse(cmbCIDRMask.Text) - Double.Parse(txtOriginalCIDR.Text)));
            }
            catch (Exception ex) { }
        }

        private void txtInputSubnetMask_TextChanged(object sender, EventArgs e)
        {
            CalculateBinaryForm((TextBox)sender, txtOutputSubnetMask);
            CreateNetworkHost();
        }

        private void cmbCIDRMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string longBinary = "";

                for (var i = 0; i < int.Parse(cmbCIDRMask.Text); i++)
                {
                    longBinary += "1";
                }

                while (longBinary.Length < 32)
                {
                    longBinary += "0";
                }

                txtInputSubnetMask.Text = new IPv4Address(String.Format("{0}.{1}.{2}.{3}",
                        NumberLogic.BinaryToInt(longBinary.Substring(0, 8)),
                        NumberLogic.BinaryToInt(longBinary.Substring(8, 8)),
                        NumberLogic.BinaryToInt(longBinary.Substring(16, 8)),
                        NumberLogic.BinaryToInt(longBinary.Substring(24, 8))
                        )).ToString();
            }
            catch (Exception ex) { }
        }

        private void btnNextNetwork_Click(object sender, EventArgs e)
        {
            NetworkHost networkHost = new NetworkHost(
                    new IPv4Address(txtInputHostIP.Text),
                    new IPv4Address(txtInputSubnetMask.Text));

            txtInputHostIP.Text = networkHost.NextNetworkID.ToString();
        }
    }
}
