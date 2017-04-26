using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace udpMessenger
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern bool FlashWindowEx(ref FLASHWINFO fi);
        private struct FLASHWINFO
        {
            public uint cbSize;
            public IntPtr hwnd;
            public uint dwFlags;
            public uint uCount;
            public uint dwTimeout;
        }
         


 

        public Form1()
        {
            InitializeComponent();          
            
        }
        
        
        UdpClient U;
        Thread listenThread;

        private void Listen()
        {
            

            int port = int.Parse(textBoxListeningPort.Text);
         
            U = new UdpClient(port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            while (true)
            {
                
                byte[] buffer = U.Receive(ref EP);
                flashWindow();
                
                String time = DateTime.Now.ToString("(HH:mm)");
                richTextBoxMessageReceived.AppendText(time + Encoding.UTF8.GetString(buffer) + "\n");
                richTextBoxMessageReceived.ScrollToCaret();
            }
        }

        private string MyIP()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hostname).AddressList;
            foreach (IPAddress iptem in ip)
            {
                if (iptem.AddressFamily == AddressFamily.InterNetwork)
                    return iptem.ToString();
            }

            return "";
        }

        private void sendMessage()
        {
            String ipAdd = textBoxTargetIP.Text;
            int port = int.Parse(textBoxTargetPort.Text);
            String text = textBoxMessageSend.Text.Trim();
            if (text == "")
            {
                textBoxMessageSend.Text = "";
                return;
            }
            String time = DateTime.Now.ToString("(HH:mm)");
            byte[] buffer = Encoding.UTF8.GetBytes(textBoxUserName.Text + ": " + text);
            textBoxMessageSend.Text = "";
            UdpClient s = new UdpClient();
            s.Send(buffer, buffer.Length, ipAdd, port);
            richTextBoxMessageReceived.AppendText(time+ Encoding.UTF8.GetString(buffer) + "\n");
            richTextBoxMessageReceived.ScrollToCaret();
            s.Close();
        }

        private void flashWindow()
        {
            FLASHWINFO FlashWINInfo = new FLASHWINFO();
            FlashWINInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(FlashWINInfo));
            FlashWINInfo.hwnd = this.Handle;
            FlashWINInfo.dwFlags = 3 | 2 | 12;
            FlashWINInfo.uCount = uint.MaxValue;
            FlashWINInfo.dwTimeout = 0;
            FlashWindowEx(ref FlashWINInfo);
        }



        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                listenThread.Abort();
                U.Close();
            }

            catch
            {
                ;
            }
        }

        private void Halt_Click(object sender, EventArgs e)
        {
            try
            {
                buttonStartListening.Enabled = true;
                listenThread.Abort();
                U.Close();
            }

            catch
            {
                ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " " + MyIP();
        }

        private void textBoxMessageSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                sendMessage();
            }
        }

        private void richTextBoxMessageReceived_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }


        private void textBoxTargetPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxListeningPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxTargetIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }









     
    }
}
