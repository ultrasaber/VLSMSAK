namespace VLSMSAK
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
            this.grpSubnetMask = new System.Windows.Forms.GroupBox();
            this.txtInputSubnetMask = new System.Windows.Forms.TextBox();
            this.txtOutputSubnetMask = new System.Windows.Forms.TextBox();
            this.grpNetworkID = new System.Windows.Forms.GroupBox();
            this.txtNetworkIDDecimal = new System.Windows.Forms.TextBox();
            this.txtNetworkIDBinary = new System.Windows.Forms.TextBox();
            this.grpHostIPAddress.SuspendLayout();
            this.grpSubnetMask.SuspendLayout();
            this.grpNetworkID.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputHostIP
            // 
            this.txtInputHostIP.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputHostIP.Location = new System.Drawing.Point(6, 19);
            this.txtInputHostIP.Name = "txtInputHostIP";
            this.txtInputHostIP.Size = new System.Drawing.Size(492, 32);
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
            this.grpHostIPAddress.Controls.Add(this.txtInputHostIP);
            this.grpHostIPAddress.Controls.Add(this.txtOutputHostIP);
            this.grpHostIPAddress.Location = new System.Drawing.Point(12, 12);
            this.grpHostIPAddress.Name = "grpHostIPAddress";
            this.grpHostIPAddress.Size = new System.Drawing.Size(508, 99);
            this.grpHostIPAddress.TabIndex = 2;
            this.grpHostIPAddress.TabStop = false;
            this.grpHostIPAddress.Text = "Host IP Address";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 334);
            this.Controls.Add(this.grpNetworkID);
            this.Controls.Add(this.grpSubnetMask);
            this.Controls.Add(this.grpHostIPAddress);
            this.Name = "frmMain";
            this.Text = "VLSMSAK";
            this.grpHostIPAddress.ResumeLayout(false);
            this.grpHostIPAddress.PerformLayout();
            this.grpSubnetMask.ResumeLayout(false);
            this.grpSubnetMask.PerformLayout();
            this.grpNetworkID.ResumeLayout(false);
            this.grpNetworkID.PerformLayout();
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
    }
}

