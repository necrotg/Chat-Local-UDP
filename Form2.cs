using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace APS
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = GetLocalIP(); 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Chat f = new Chat();
            this.Hide();
            f.ShowDialog();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
