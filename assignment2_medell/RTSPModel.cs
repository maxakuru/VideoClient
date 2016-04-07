using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_medell
{
    class RTSPModel
    {
        private int portNo;
        public IPAddress serverIP;
        byte[] receiveBuffer = new byte[1024];
        Socket RTSPSocket = null;
        IPEndPoint serverEP = null;

        public RTSPModel(int p, string ip)
        {
            this.portNo = p;
            try
            {
                this.serverIP = IPAddress.Parse(ip);
            }
            catch (FormatException err)
            {
                MessageBox.Show(String.Format("{0}", err.Message), "Invalid IP address");
            }

            

            try
            {
                //Create TCP socket
                serverEP = new IPEndPoint(serverIP, portNo);

                RTSPSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //RTSPSocket.Bind(serverEP);
            }
            catch (SocketException err)
            {
                if (RTSPSocket != null)
                    RTSPSocket.Close();
                MessageBox.Show(String.Format("{0}", err.Message), "Socket error");
            }

            try
            {
                //RTSPSocket.Listen(int.MaxValue);
                RTSPSocket.Connect(serverEP);
            }
            catch 
            { 
            }
            

        }

        internal Socket AcceptServer()
        {
            return RTSPSocket;
            
        }
    }
}
