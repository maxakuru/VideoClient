using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_medell
{
    class RTPModel
    {
        UdpClient udpClient;
        Socket udpSocket = null;
        IPEndPoint EP = null;
        int receiveLength;
        EndPoint EP2 = null;
        int portNo;

        public RTPModel(string ip)
        {
            try
            {
                IPAddress destAddress = IPAddress.Parse(ip);
                udpClient = new UdpClient(0);
                EP = new IPEndPoint(IPAddress.Any, 0);
                //udpClient.Connect(destAddress, 0);
                portNo = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;
                //EP2 = (EndPoint)EP;
                //udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //udpSocket.Bind(destEndPoint);
            }
            catch
            { 
            }
        }

        public int getPort()
        {
            return portNo;
        }

        public void close()
        {
            //udpSocket.Close();
            udpClient.Close();
        }

        public Socket getSocket()
        {
            return udpSocket;
        }

        public IPEndPoint getIPEP()
        {
            return EP;
        }

        internal void sendStuff(byte[] p)
        {
            udpSocket.SendTo(p, EP);
        }

        public int getReceiveLength()
        {
            return receiveLength;
        }

        internal byte[] getStuff()
        {
            Byte[] toReturn = udpClient.Receive(ref EP);
            receiveLength = toReturn.Length;
            return toReturn;
            /*
             byte[] toReturn = new byte[100000];
             receiveLength = udpSocket.ReceiveFrom(toReturn, ref EP2);
             return toReturn;
             * */
        }
    }

}
