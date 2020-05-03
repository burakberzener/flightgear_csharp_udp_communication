using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

#region TM_DegiskenTanimlari

using UINT8 = System.Byte;
using INT8 = System.SByte;
using UINT16 = System.UInt16;
using INT16 = System.Int16;
using UINT32 = System.UInt32;
using INT32 = System.Int32;
using UINT64 = System.UInt64;
using FLOAT32 = System.Single;
using FLOAT64 = System.Double;

#endregion

namespace UDP
{
    public class UDPSocket
    {
        private Socket _socket;
        private const int bufSize = 60;
        private State state = new State();
        private EndPoint epFrom = new IPEndPoint(IPAddress.Any, 0);
        private AsyncCallback recv = null;

        public class State
        {
            public byte[] buffer = new byte[bufSize];
        }

        public void Server(string address, int port)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);
            _socket.Bind(new IPEndPoint(IPAddress.Parse(address), port));
            Receive();
        }

        public void Close()
        {
            try
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
            catch 
            {
            }

        }

        public void Client(string address, int port)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Connect(IPAddress.Parse(address), port);
            Receive();
        }

        public void Send(string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            _socket.BeginSend(data, 0, data.Length, SocketFlags.None, (ar) =>
            {
                State so = (State)ar.AsyncState;
                int bytes = _socket.EndSend(ar);
                Console.WriteLine("SEND: {0}, {1}", bytes, text);
            }, state);
        }

        private void Receive()
        {
            _socket.BeginReceiveFrom(state.buffer, 0, bufSize, SocketFlags.None, ref epFrom, recv = (ar) =>
            {
                try
                {
                    State so = (State)ar.AsyncState;
                    UINT8 count = (UINT8)_socket.EndReceiveFrom(ar, ref epFrom);
                    OnSerialReceiving(so.buffer);
                    //Console.WriteLine(so.buffer[1]);
                    _socket.BeginReceiveFrom(so.buffer, 0, bufSize, SocketFlags.None, ref epFrom, recv, so);              
                }
                catch { }

            }, state);
        }

        #region Event Handler
        public event EventHandler<DataStreamEventArgs> OnReceiving;
        #endregion

        #region EventsHandlers Function
        private void OnSerialReceiving(UINT8[] res)
        {
            if (OnReceiving != null)
            {
                OnReceiving(this, new DataStreamEventArgs(res));
            }
        }
        #endregion
    }

    public class DataStreamEventArgs : EventArgs
    {
        #region Tanimlama
        private UINT8[] _bytes;
        #endregion

        #region Constructors
        public DataStreamEventArgs(UINT8[] bytes)
        {
            _bytes = bytes;
  
        }
        #endregion

        #region Properties
        public UINT8[] Receive
        {
            get { return _bytes; }
        }

        #endregion
    }
}