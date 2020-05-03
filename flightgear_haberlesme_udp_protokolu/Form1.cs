using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.Device.Location;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UITimer = System.Windows.Forms.Timer;

namespace flightgear_haberlesme_udp_protokolu
{
    public partial class Form1 : Form
    {
        double fg_lat, fg_longt;
        string throttle, aileron, elevator, rudder, message;

        //UDP PARAMETERS
        private const int receivePort = 5555;
        private const int sendPort = 5554;
        UdpClient udp_receive = new UdpClient(receivePort);
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), receivePort);
        UdpClient udp_send = new UdpClient(sendPort);
        IPEndPoint sendPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), sendPort);

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            udp_receive.BeginReceive(new AsyncCallback(udpReceive), null);
            message = "0,0;0,0|";
            udpSend_t.Start();
        }

        private void udpReceive(IAsyncResult ar)
        {
            byte[] udp_buffer = udp_receive.EndReceive(ar, ref endPoint);
            string udp_message = Encoding.ASCII.GetString(udp_buffer);
            string[] udp_chunks = udp_message.Substring(0, udp_message.Length - 1).Split(';');

            fg_lat = Convert.ToDouble(udp_chunks[1]) / 1000000;
            fg_longt = Convert.ToDouble(udp_chunks[2]) / 1000000;

            txt1.Text = "Airspeed: " + udp_chunks[0];
            txt2.Text = "Latitude: " + udp_chunks[1];
            txt3.Text = "Longitude: " + udp_chunks[2];
            txt4.Text = "Altitude: " + udp_chunks[3];
            txt5.Text = "Roll: " + udp_chunks[4];
            txt6.Text = "Pitch: " + udp_chunks[5];
            txt7.Text = "Heading: " + udp_chunks[6];

            udp_message_tb.Text = udp_message;

            udp_receive.BeginReceive(new AsyncCallback(udpReceive), null);
        }

        private void udpSend_t_Tick(object sender, EventArgs e)
        {
            throttle = Convert.ToString(Convert.ToDouble(throttle_tb.Value) / 100);
            aileron = Convert.ToString(Convert.ToDouble(aileron_tb.Value) / 100);
            elevator = Convert.ToString(Convert.ToDouble(elevator_tb.Value) / 100);
            rudder = Convert.ToString(Convert.ToDouble(rudder_tb.Value) / 100);
            message = throttle + ";" + aileron + ";" + elevator + ";" + rudder + "|\n";
            message = message.Replace(",",".");
            byte[] udp_send_buffer = Encoding.ASCII.GetBytes(message);
            send_tb.Text = message;
            udp_send.Send(udp_send_buffer, udp_send_buffer.Length, sendPoint);
        }
    }
}
