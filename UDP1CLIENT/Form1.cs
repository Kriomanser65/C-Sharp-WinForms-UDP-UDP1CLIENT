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
using System.Windows.Forms;

namespace UDP1CLIENT
{
    public partial class Form1 : Form
    {
        UdpClient client;
        IPEndPoint remoteEndpoint;
        TextBox textBoxId;
        TextBox textBoxMinPrice;
        TextBox textBoxMaxPrice;
        TextBox textBoxBrand;
        TextBox textBoxModel;
        TextBox textBoxResult;
        public Form1()
        {
            InitializeComponent();
            client = new UdpClient();
            remoteEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            textBoxId = textBox1;
            textBoxMinPrice = textBox2;
            textBoxMaxPrice = textBox3;
            textBoxBrand = textBox4;
            textBoxModel = textBox5;
            textBoxResult = textBox6;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchId_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes("1:" + textBoxId.Text);
            SendReceive(message);
        }

        private void SearchPrice_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes("2:" + textBoxMinPrice.Text + ":" + textBoxMaxPrice.Text);
            SendReceive(message);
        }

        private void SearchModel_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes("3:" + textBoxBrand.Text + ":" + textBoxModel.Text);
            SendReceive(message);
        }

        private void SetUnaviable_Click(object sender, EventArgs e)
        {
            var message = Encoding.UTF8.GetBytes("4:" + textBoxId.Text);
            SendReceive(message);
        }
        private void SendReceive(byte[] message)
        {
            client.Send(message, message.Length, remoteEndpoint);
            var receiveBytes = client.Receive(ref remoteEndpoint);
            var receiveMsg = Encoding.UTF8.GetString(receiveBytes);
            textBoxResult.Text = receiveMsg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
