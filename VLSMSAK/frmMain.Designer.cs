﻿namespace VLSMSAK
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputHostIP = new System.Windows.Forms.TextBox();
            this.txtOutputHostIP = new System.Windows.Forms.TextBox();
            this.grpHostIPAddress = new System.Windows.Forms.GroupBox();
            this.cmbCIDRMask = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSubnetMask = new System.Windows.Forms.GroupBox();
            this.txtInputSubnetMask = new System.Windows.Forms.TextBox();
            this.txtOutputSubnetMask = new System.Windows.Forms.TextBox();
            this.grpNetworkID = new System.Windows.Forms.GroupBox();
            this.txtNetworkIDDecimal = new System.Windows.Forms.TextBox();
            this.txtNetworkIDBinary = new System.Windows.Forms.TextBox();
            this.grpFirstHostAddress = new System.Windows.Forms.GroupBox();
            this.txtFirstHostAddressDecimal = new System.Windows.Forms.TextBox();
            this.txtFirstHostAddressBinary = new System.Windows.Forms.TextBox();
            this.grpBroadcastAddress = new System.Windows.Forms.GroupBox();
            this.txtBroadcastAddressDecimal = new System.Windows.Forms.TextBox();
            this.txtBroadcastAddressBinary = new System.Windows.Forms.TextBox();
            this.grpLastHostAddress = new System.Windows.Forms.GroupBox();
            this.txtLastHostAddressDecimal = new System.Windows.Forms.TextBox();
            this.txtLastHostAddressBinary = new System.Windows.Forms.TextBox();
            this.grpNetworkControls = new System.Windows.Forms.GroupBox();
            this.btnNextNetwork = new System.Windows.Forms.Button();
            this.grpHosts = new System.Windows.Forms.GroupBox();
            this.txtHosts = new System.Windows.Forms.TextBox();
            this.grpNetworks = new System.Windows.Forms.GroupBox();
            this.txtNetworks = new System.Windows.Forms.TextBox();
            this.grpOriginalCIDR = new System.Windows.Forms.GroupBox();
            this.txtOriginalCIDR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpHostIPAddress.SuspendLayout();
            this.grpSubnetMask.SuspendLayout();
            this.grpNetworkID.SuspendLayout();
            this.grpFirstHostAddress.SuspendLayout();
            this.grpBroadcastAddress.SuspendLayout();
            this.grpLastHostAddress.SuspendLayout();
            this.grpNetworkControls.SuspendLayout();
            this.grpHosts.SuspendLayout();
            this.grpNetworks.SuspendLayout();
            this.grpOriginalCIDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputHostIP
            // 
            this.txtInputHostIP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputHostIP.Location = new System.Drawing.Point(6, 19);
            this.txtInputHostIP.Name = "txtInputHostIP";
            this.txtInputHostIP.Size = new System.Drawing.Size(409, 32);
            this.txtInputHostIP.TabIndex = 0;
            this.txtInputHostIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputHostIP.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutputHostIP
            // 
            this.txtOutputHostIP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOutputHostIP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputHostIP.Location = new System.Drawing.Point(6, 57);
            this.txtOutputHostIP.Name = "txtOutputHostIP";
            this.txtOutputHostIP.ReadOnly = true;
            this.txtOutputHostIP.Size = new System.Drawing.Size(492, 32);
            this.txtOutputHostIP.TabIndex = 1;
            this.txtOutputHostIP.Text = "00000000.00000000.00000000.00000000";
            this.txtOutputHostIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpHostIPAddress
            // 
            this.grpHostIPAddress.Controls.Add(this.cmbCIDRMask);
            this.grpHostIPAddress.Controls.Add(this.label1);
            this.grpHostIPAddress.Controls.Add(this.txtInputHostIP);
            this.grpHostIPAddress.Controls.Add(this.txtOutputHostIP);
            this.grpHostIPAddress.Location = new System.Drawing.Point(12, 12);
            this.grpHostIPAddress.Name = "grpHostIPAddress";
            this.grpHostIPAddress.Size = new System.Drawing.Size(508, 99);
            this.grpHostIPAddress.TabIndex = 2;
            this.grpHostIPAddress.TabStop = false;
            this.grpHostIPAddress.Text = "Host IP Address";
            // 
            // cmbCIDRMask
            // 
            this.cmbCIDRMask.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCIDRMask.FormattingEnabled = true;
            this.cmbCIDRMask.Location = new System.Drawing.Point(445, 19);
            this.cmbCIDRMask.MaxDropDownItems = 33;
            this.cmbCIDRMask.Name = "cmbCIDRMask";
            this.cmbCIDRMask.Size = new System.Drawing.Size(53, 32);
            this.cmbCIDRMask.TabIndex = 3;
            this.cmbCIDRMask.TextChanged += new System.EventHandler(this.cmbCIDRMask_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // grpSubnetMask
            // 
            this.grpSubnetMask.Controls.Add(this.txtInputSubnetMask);
            this.grpSubnetMask.Controls.Add(this.txtOutputSubnetMask);
            this.grpSubnetMask.Location = new System.Drawing.Point(12, 117);
            this.grpSubnetMask.Name = "grpSubnetMask";
            this.grpSubnetMask.Size = new System.Drawing.Size(508, 99);
            this.grpSubnetMask.TabIndex = 3;
            this.grpSubnetMask.TabStop = false;
            this.grpSubnetMask.Text = "Subnet Mask";
            // 
            // txtInputSubnetMask
            // 
            this.txtInputSubnetMask.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSubnetMask.Location = new System.Drawing.Point(6, 19);
            this.txtInputSubnetMask.Name = "txtInputSubnetMask";
            this.txtInputSubnetMask.Size = new System.Drawing.Size(492, 32);
            this.txtInputSubnetMask.TabIndex = 0;
            this.txtInputSubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputSubnetMask.TextChanged += new System.EventHandler(this.txtInputSubnetMask_TextChanged);
            // 
            // txtOutputSubnetMask
            // 
            this.txtOutputSubnetMask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOutputSubnetMask.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputSubnetMask.Location = new System.Drawing.Point(6, 57);
            this.txtOutputSubnetMask.Name = "txtOutputSubnetMask";
            this.txtOutputSubnetMask.ReadOnly = true;
            this.txtOutputSubnetMask.Size = new System.Drawing.Size(492, 32);
            this.txtOutputSubnetMask.TabIndex = 1;
            this.txtOutputSubnetMask.Text = "00000000.00000000.00000000.00000000";
            this.txtOutputSubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpNetworkID
            // 
            this.grpNetworkID.Controls.Add(this.txtNetworkIDDecimal);
            this.grpNetworkID.Controls.Add(this.txtNetworkIDBinary);
            this.grpNetworkID.Location = new System.Drawing.Point(12, 222);
            this.grpNetworkID.Name = "grpNetworkID";
            this.grpNetworkID.Size = new System.Drawing.Size(508, 99);
            this.grpNetworkID.TabIndex = 4;
            this.grpNetworkID.TabStop = false;
            this.grpNetworkID.Text = "Network ID";
            // 
            // txtNetworkIDDecimal
            // 
            this.txtNetworkIDDecimal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNetworkIDDecimal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetworkIDDecimal.Location = new System.Drawing.Point(6, 19);
            this.txtNetworkIDDecimal.Name = "txtNetworkIDDecimal";
            this.txtNetworkIDDecimal.ReadOnly = true;
            this.txtNetworkIDDecimal.Size = new System.Drawing.Size(492, 32);
            this.txtNetworkIDDecimal.TabIndex = 0;
            this.txtNetworkIDDecimal.Text = "0.0.0.0";
            this.txtNetworkIDDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNetworkIDBinary
            // 
            this.txtNetworkIDBinary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNetworkIDBinary.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetworkIDBinary.Location = new System.Drawing.Point(6, 57);
            this.txtNetworkIDBinary.Name = "txtNetworkIDBinary";
            this.txtNetworkIDBinary.ReadOnly = true;
            this.txtNetworkIDBinary.Size = new System.Drawing.Size(492, 32);
            this.txtNetworkIDBinary.TabIndex = 1;
            this.txtNetworkIDBinary.Text = "00000000.00000000.00000000.00000000";
            this.txtNetworkIDBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpFirstHostAddress
            // 
            this.grpFirstHostAddress.Controls.Add(this.txtFirstHostAddressDecimal);
            this.grpFirstHostAddress.Controls.Add(this.txtFirstHostAddressBinary);
            this.grpFirstHostAddress.Location = new System.Drawing.Point(12, 327);
            this.grpFirstHostAddress.Name = "grpFirstHostAddress";
            this.grpFirstHostAddress.Size = new System.Drawing.Size(508, 99);
            this.grpFirstHostAddress.TabIndex = 5;
            this.grpFirstHostAddress.TabStop = false;
            this.grpFirstHostAddress.Text = "First Host Address";
            // 
            // txtFirstHostAddressDecimal
            // 
            this.txtFirstHostAddressDecimal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFirstHostAddressDecimal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstHostAddressDecimal.Location = new System.Drawing.Point(6, 19);
            this.txtFirstHostAddressDecimal.Name = "txtFirstHostAddressDecimal";
            this.txtFirstHostAddressDecimal.ReadOnly = true;
            this.txtFirstHostAddressDecimal.Size = new System.Drawing.Size(492, 32);
            this.txtFirstHostAddressDecimal.TabIndex = 0;
            this.txtFirstHostAddressDecimal.Text = "0.0.0.0";
            this.txtFirstHostAddressDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstHostAddressBinary
            // 
            this.txtFirstHostAddressBinary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFirstHostAddressBinary.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstHostAddressBinary.Location = new System.Drawing.Point(6, 57);
            this.txtFirstHostAddressBinary.Name = "txtFirstHostAddressBinary";
            this.txtFirstHostAddressBinary.ReadOnly = true;
            this.txtFirstHostAddressBinary.Size = new System.Drawing.Size(492, 32);
            this.txtFirstHostAddressBinary.TabIndex = 1;
            this.txtFirstHostAddressBinary.Text = "00000000.00000000.00000000.00000000";
            this.txtFirstHostAddressBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBroadcastAddress
            // 
            this.grpBroadcastAddress.Controls.Add(this.txtBroadcastAddressDecimal);
            this.grpBroadcastAddress.Controls.Add(this.txtBroadcastAddressBinary);
            this.grpBroadcastAddress.Location = new System.Drawing.Point(12, 537);
            this.grpBroadcastAddress.Name = "grpBroadcastAddress";
            this.grpBroadcastAddress.Size = new System.Drawing.Size(508, 99);
            this.grpBroadcastAddress.TabIndex = 6;
            this.grpBroadcastAddress.TabStop = false;
            this.grpBroadcastAddress.Text = "Broadcast Address";
            // 
            // txtBroadcastAddressDecimal
            // 
            this.txtBroadcastAddressDecimal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBroadcastAddressDecimal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroadcastAddressDecimal.Location = new System.Drawing.Point(6, 19);
            this.txtBroadcastAddressDecimal.Name = "txtBroadcastAddressDecimal";
            this.txtBroadcastAddressDecimal.ReadOnly = true;
            this.txtBroadcastAddressDecimal.Size = new System.Drawing.Size(492, 32);
            this.txtBroadcastAddressDecimal.TabIndex = 0;
            this.txtBroadcastAddressDecimal.Text = "0.0.0.0";
            this.txtBroadcastAddressDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBroadcastAddressBinary
            // 
            this.txtBroadcastAddressBinary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBroadcastAddressBinary.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroadcastAddressBinary.Location = new System.Drawing.Point(6, 57);
            this.txtBroadcastAddressBinary.Name = "txtBroadcastAddressBinary";
            this.txtBroadcastAddressBinary.ReadOnly = true;
            this.txtBroadcastAddressBinary.Size = new System.Drawing.Size(492, 32);
            this.txtBroadcastAddressBinary.TabIndex = 1;
            this.txtBroadcastAddressBinary.Text = "00000000.00000000.00000000.00000000";
            this.txtBroadcastAddressBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpLastHostAddress
            // 
            this.grpLastHostAddress.Controls.Add(this.txtLastHostAddressDecimal);
            this.grpLastHostAddress.Controls.Add(this.txtLastHostAddressBinary);
            this.grpLastHostAddress.Location = new System.Drawing.Point(12, 432);
            this.grpLastHostAddress.Name = "grpLastHostAddress";
            this.grpLastHostAddress.Size = new System.Drawing.Size(508, 99);
            this.grpLastHostAddress.TabIndex = 7;
            this.grpLastHostAddress.TabStop = false;
            this.grpLastHostAddress.Text = "Last Host Address";
            // 
            // txtLastHostAddressDecimal
            // 
            this.txtLastHostAddressDecimal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastHostAddressDecimal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastHostAddressDecimal.Location = new System.Drawing.Point(6, 19);
            this.txtLastHostAddressDecimal.Name = "txtLastHostAddressDecimal";
            this.txtLastHostAddressDecimal.ReadOnly = true;
            this.txtLastHostAddressDecimal.Size = new System.Drawing.Size(492, 32);
            this.txtLastHostAddressDecimal.TabIndex = 0;
            this.txtLastHostAddressDecimal.Text = "0.0.0.0";
            this.txtLastHostAddressDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastHostAddressBinary
            // 
            this.txtLastHostAddressBinary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastHostAddressBinary.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastHostAddressBinary.Location = new System.Drawing.Point(6, 57);
            this.txtLastHostAddressBinary.Name = "txtLastHostAddressBinary";
            this.txtLastHostAddressBinary.ReadOnly = true;
            this.txtLastHostAddressBinary.Size = new System.Drawing.Size(492, 32);
            this.txtLastHostAddressBinary.TabIndex = 1;
            this.txtLastHostAddressBinary.Text = "00000000.00000000.00000000.00000000";
            this.txtLastHostAddressBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpNetworkControls
            // 
            this.grpNetworkControls.Controls.Add(this.btnNextNetwork);
            this.grpNetworkControls.Location = new System.Drawing.Point(526, 222);
            this.grpNetworkControls.Name = "grpNetworkControls";
            this.grpNetworkControls.Size = new System.Drawing.Size(141, 414);
            this.grpNetworkControls.TabIndex = 8;
            this.grpNetworkControls.TabStop = false;
            this.grpNetworkControls.Text = "Network Controls";
            // 
            // btnNextNetwork
            // 
            this.btnNextNetwork.Location = new System.Drawing.Point(7, 19);
            this.btnNextNetwork.Name = "btnNextNetwork";
            this.btnNextNetwork.Size = new System.Drawing.Size(128, 23);
            this.btnNextNetwork.TabIndex = 0;
            this.btnNextNetwork.Text = "Next Network";
            this.btnNextNetwork.UseVisualStyleBackColor = true;
            this.btnNextNetwork.Click += new System.EventHandler(this.btnNextNetwork_Click);
            // 
            // grpHosts
            // 
            this.grpHosts.Controls.Add(this.txtHosts);
            this.grpHosts.Location = new System.Drawing.Point(526, 151);
            this.grpHosts.Name = "grpHosts";
            this.grpHosts.Size = new System.Drawing.Size(141, 64);
            this.grpHosts.TabIndex = 9;
            this.grpHosts.TabStop = false;
            this.grpHosts.Text = "Available Hosts";
            // 
            // txtHosts
            // 
            this.txtHosts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtHosts.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHosts.Location = new System.Drawing.Point(7, 21);
            this.txtHosts.Name = "txtHosts";
            this.txtHosts.ReadOnly = true;
            this.txtHosts.Size = new System.Drawing.Size(128, 32);
            this.txtHosts.TabIndex = 4;
            this.txtHosts.Text = "0";
            this.txtHosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpNetworks
            // 
            this.grpNetworks.Controls.Add(this.txtNetworks);
            this.grpNetworks.Location = new System.Drawing.Point(526, 81);
            this.grpNetworks.Name = "grpNetworks";
            this.grpNetworks.Size = new System.Drawing.Size(141, 64);
            this.grpNetworks.TabIndex = 10;
            this.grpNetworks.TabStop = false;
            this.grpNetworks.Text = "Available Subnetworks";
            // 
            // txtNetworks
            // 
            this.txtNetworks.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNetworks.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetworks.Location = new System.Drawing.Point(7, 21);
            this.txtNetworks.Name = "txtNetworks";
            this.txtNetworks.ReadOnly = true;
            this.txtNetworks.Size = new System.Drawing.Size(128, 32);
            this.txtNetworks.TabIndex = 4;
            this.txtNetworks.Text = "0";
            this.txtNetworks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpOriginalCIDR
            // 
            this.grpOriginalCIDR.Controls.Add(this.label2);
            this.grpOriginalCIDR.Controls.Add(this.txtOriginalCIDR);
            this.grpOriginalCIDR.Location = new System.Drawing.Point(526, 12);
            this.grpOriginalCIDR.Name = "grpOriginalCIDR";
            this.grpOriginalCIDR.Size = new System.Drawing.Size(141, 63);
            this.grpOriginalCIDR.TabIndex = 11;
            this.grpOriginalCIDR.TabStop = false;
            this.grpOriginalCIDR.Text = "Original Mask";
            // 
            // txtOriginalCIDR
            // 
            this.txtOriginalCIDR.BackColor = System.Drawing.SystemColors.Window;
            this.txtOriginalCIDR.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalCIDR.Location = new System.Drawing.Point(34, 21);
            this.txtOriginalCIDR.Name = "txtOriginalCIDR";
            this.txtOriginalCIDR.Size = new System.Drawing.Size(101, 32);
            this.txtOriginalCIDR.TabIndex = 4;
            this.txtOriginalCIDR.Text = "0";
            this.txtOriginalCIDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 643);
            this.Controls.Add(this.grpOriginalCIDR);
            this.Controls.Add(this.grpNetworks);
            this.Controls.Add(this.grpHosts);
            this.Controls.Add(this.grpNetworkControls);
            this.Controls.Add(this.grpLastHostAddress);
            this.Controls.Add(this.grpBroadcastAddress);
            this.Controls.Add(this.grpFirstHostAddress);
            this.Controls.Add(this.grpNetworkID);
            this.Controls.Add(this.grpSubnetMask);
            this.Controls.Add(this.grpHostIPAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "VLSMSAK";
            this.grpHostIPAddress.ResumeLayout(false);
            this.grpHostIPAddress.PerformLayout();
            this.grpSubnetMask.ResumeLayout(false);
            this.grpSubnetMask.PerformLayout();
            this.grpNetworkID.ResumeLayout(false);
            this.grpNetworkID.PerformLayout();
            this.grpFirstHostAddress.ResumeLayout(false);
            this.grpFirstHostAddress.PerformLayout();
            this.grpBroadcastAddress.ResumeLayout(false);
            this.grpBroadcastAddress.PerformLayout();
            this.grpLastHostAddress.ResumeLayout(false);
            this.grpLastHostAddress.PerformLayout();
            this.grpNetworkControls.ResumeLayout(false);
            this.grpHosts.ResumeLayout(false);
            this.grpHosts.PerformLayout();
            this.grpNetworks.ResumeLayout(false);
            this.grpNetworks.PerformLayout();
            this.grpOriginalCIDR.ResumeLayout(false);
            this.grpOriginalCIDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputHostIP;
        private System.Windows.Forms.TextBox txtOutputHostIP;
        private System.Windows.Forms.GroupBox grpHostIPAddress;
        private System.Windows.Forms.GroupBox grpSubnetMask;
        private System.Windows.Forms.TextBox txtInputSubnetMask;
        private System.Windows.Forms.TextBox txtOutputSubnetMask;
        private System.Windows.Forms.GroupBox grpNetworkID;
        private System.Windows.Forms.TextBox txtNetworkIDDecimal;
        private System.Windows.Forms.TextBox txtNetworkIDBinary;
        private System.Windows.Forms.GroupBox grpFirstHostAddress;
        private System.Windows.Forms.TextBox txtFirstHostAddressDecimal;
        private System.Windows.Forms.TextBox txtFirstHostAddressBinary;
        private System.Windows.Forms.GroupBox grpBroadcastAddress;
        private System.Windows.Forms.TextBox txtBroadcastAddressDecimal;
        private System.Windows.Forms.TextBox txtBroadcastAddressBinary;
        private System.Windows.Forms.GroupBox grpLastHostAddress;
        private System.Windows.Forms.TextBox txtLastHostAddressDecimal;
        private System.Windows.Forms.TextBox txtLastHostAddressBinary;
        private System.Windows.Forms.ComboBox cmbCIDRMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpNetworkControls;
        private System.Windows.Forms.Button btnNextNetwork;
        private System.Windows.Forms.GroupBox grpHosts;
        private System.Windows.Forms.TextBox txtHosts;
        private System.Windows.Forms.GroupBox grpNetworks;
        private System.Windows.Forms.TextBox txtNetworks;
        private System.Windows.Forms.GroupBox grpOriginalCIDR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOriginalCIDR;
    }
}

