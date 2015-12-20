using ESP8266SerialSetupLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP8266Configurator
{
    public partial class ESP8266ConfigForm : Form
    {
        ESP8266SerialSetup setup = null;
        public ESP8266ConfigForm()
        {
            InitializeComponent();
        }

        private void SetupPort()
        {
            if (setup != null)
            {
                if (setup.PortName != cmbPort.SelectedItem.ToString())
                {
                    setup.Close();
                    setup = null;
                }
            }
            if (setup == null)
            {
                setup = new ESP8266SerialSetup(cmbPort.SelectedItem.ToString());
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            try
            {
                SetupPort();
                setup.SetSSID(txtSSID.Text);
                setup.SetPassword(txtPassword.Text);
                setup.SetRemoteIP(txtRemoteIp1.Text + "." + txtRemoteIp2.Text + "." + txtRemoteIp3.Text + "." + txtRemoteIp4.Text);
                setup.SetRemotePort(Int32.Parse(txtRemotePort.Text));
                setup.Reconnect();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not connect to selected port");
            }
        }

        private void ESP8266ConfigForm_Load(object sender, EventArgs e)
        {
            cmbPort.Items.Clear();
            foreach (String port in ESP8266SerialSetupLib.ESP8266SerialSetup.PortNames)
            {
                cmbPort.Items.Add(port);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (setup != null)
            {
                List<String> newLinews = setup.FlushBuffer();
                foreach (String s in newLinews)
                {
                    txtLog.AppendText(s);
                }
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                SetupPort();
                setup.ShowStatus();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not connect to selected port");
            }
        }
    }
}
