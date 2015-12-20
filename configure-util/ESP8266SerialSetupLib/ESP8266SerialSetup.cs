using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP8266SerialSetupLib
{
    public class ESP8266SerialSetup
    {
        String portName;
        SerialPort port;
        private SerialDataReceivedEventHandler onReceiveHandler;
        List<String> buf = new List<string>();
        public ESP8266SerialSetup(String portName)
        {
            this.portName = portName;
            port = new SerialPort(portName);
            port.BaudRate = 57600;
            port.Open();
            onReceiveHandler = new SerialDataReceivedEventHandler(OnReceive);
            port.DataReceived += onReceiveHandler;
            port.NewLine = "\n";
        }

        public String PortName
        {
            get { return portName; }
        }

        public static string [] PortNames
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }

        public bool PortHasData() { return (port.BytesToRead > 0); }

        public List<String> FlushBuffer()
        {
            lock (this)
            {
                List<String> res = buf;
                buf = new List<string>();
                return res;
            }
        }

        void OnReceive(Object sender, SerialDataReceivedEventArgs e)
        {
            lock (this)
            {
                List<byte> buffer = new List<byte>();
                while (PortHasData()) buffer.Add((byte)port.ReadByte());
                buf.Add(ASCIIEncoding.ASCII.GetString(buffer.ToArray()));
            }
        }

        public void Close()
        {
            port.Close();
        }

        public void SetSSID(String ssid)
        {
            port.WriteLine("set ssid " + ssid);
        }

        public void SetPassword(String password)
        {
            port.WriteLine("set pass " + password);
        }

        public void SetRemoteIP(String ipv4Dotted)
        {
            port.WriteLine("set remote ip " + ipv4Dotted);
        }

        public void SetRemotePort(int ipv4Port)
        {
            port.WriteLine("set remote port " + ipv4Port);
        }

        public void ShowStatus()
        {
            port.WriteLine("status");
        }

        public void Reconnect()
        {
            port.WriteLine("connect");
        }
    }
}
