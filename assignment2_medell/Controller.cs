using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_medell
{
    class Controller
    {
        View _view;
        RTSPModel _RTSPModel = null;
        Thread serverThread;
        RTPModel _RTPmodel = null;
        int sessionId = 0;
        int cseq;
        int RTP_PORT;
        Socket _RTSPSocket = null;
        bool setSession = true;
        System.Timers.Timer timer;

        public Controller()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 80;
            timer.Elapsed += OnElapsedEvent;
            //_view = new View();
        }

        private void OnElapsedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            //get the packet that was sent
            byte[] rc = _RTPmodel.getStuff();
            int length = _RTPmodel.getReceiveLength();

            if (_view.printHeader())
            {
                byte[] header = new byte[12];
                for(int i=0;i<12;i++)
                {
                    header[i] = rc[i];
                }
                var result = string.Concat(header.Select(b => Convert.ToString(b, 2).PadLeft(8, '0').PadRight(9, ' ')));
                updateInfoBox(result + "\r\n");
            }

            Bitmap bmp;
            using (var ms = new MemoryStream(rc, 12, length-12))
            {
                bmp = new Bitmap(ms);
            }
            _view.putFrame(bmp);

            if(_view.packetReport())
            {   
                int type = rc[1] & 0x7f;
                int i = 2;
                int seqNum = (rc[i++] << 8 | rc[i++]);
                int timestamp = (rc[i++] << 24) | (rc[i++] << 16) | (rc[i++] << 8) | rc[i++];
                updateInfoBox("Got RTP packet with SeqNum #" + seqNum + " Timestamp " + timestamp + "ms, of type " + type + "\r\n");
            }
        }

        internal void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                _view = (View)((Button)sender).FindForm();
                _view.Disable_ConnectButton();
                _RTSPModel = new RTSPModel(Int32.Parse(_view.getPortNumber()), _view.getIpAddress());
                _RTSPSocket = _RTSPModel.AcceptServer();

                //updateInfoBox("The client " + _RTSPSocket.RemoteEndPoint.ToString() + " has joined" + "\r\n");
                serverThread = new Thread(new ParameterizedThreadStart(Communications));
                serverThread.IsBackground = true;
                serverThread.Start(_RTSPSocket);
            }
            catch { }
        }

        private void updateInfoBox(string p)
        {
            _view.SetInfoBox(p);
        }

        private void Communications(object obj)
        {
            Socket s = (Socket)obj;
            byte[] receiveBuffer = new byte[256];
            //_RTPmodel = new RTPModel(_view.getIpAddress());

            try
            {
                while (true)
                {
                    int rc = s.Receive(receiveBuffer);
                    if (rc == 0)
                        break;
                    string str = System.Text.Encoding.UTF8.GetString(receiveBuffer, 0, rc);
                    
                    _view.SetServerBox(str + "\r\n");
                    if (setSession) //set session id once
                    {
                        string[] ss = str.Split(new char[] { ' ' });
                        sessionId = Convert.ToInt32(ss[ss.Length - 1]);
                        setSession = false;
                    }

                }
            }
            catch(SocketException err)
            {
                if (s != null)
                    s.Close();
            }
            finally 
            {
                s.Close();
            }
        }

        internal void button_setup_click(object sender, EventArgs e)
        {
            cseq = 1;
            updateInfoBox("New RTSP state: READY\r\n");
            _RTPmodel = new RTPModel(_view.getIpAddress());
            RTP_PORT = _RTPmodel.getPort();
            string requestLine = "SETUP rtsp://" + _view.getIpAddress() +":"+ _view.getPortNumber() +"/"+ _view.getVideoName()+ " RTSP/1.0\r\n";
            string cseqLine = "CSeq: " + cseq++ + "\r\n";
            string sessionLine = "Transport: RTP/UDP; client_port= " + RTP_PORT + "\r\n";
            //string sessionLine = "Transport: RTP/UDP; client_port= 25000" + "\r\n";
            string message = requestLine + cseqLine + sessionLine;
            byte[] messageBytes = System.Text.Encoding.ASCII.GetBytes(message);
            _RTSPSocket.Send(messageBytes);
        }

        internal void button_play_click(object sender, EventArgs e)
        {
            updateInfoBox("New RTSP state: PLAYING\r\n");
            string requestLine = "PLAY rtsp://" + _view.getIpAddress() + ":" + _view.getPortNumber() + "/" + _view.getVideoName() + " RTSP/1.0\r\n";
            string cseqLine = "CSeq: " + cseq++ + "\r\n";
            string sessionLine = "Session: " + sessionId + "\r\n";
            string message = requestLine + cseqLine + sessionLine;
            byte[] messageBytes = System.Text.Encoding.ASCII.GetBytes(message);
            _RTSPSocket.Send(messageBytes);

            timer.Start();
        }

        internal void button_pause_click(object sender, EventArgs e)
        {
            updateInfoBox("New RTSP state: READY\r\n");
            string requestLine = "PAUSE rtsp://" + _view.getIpAddress() + ":" + _view.getPortNumber() + "/" + _view.getVideoName() + " RTSP/1.0\r\n";
            string cseqLine = "CSeq: " + cseq++ + "\r\n";
            string sessionLine = "Session: " + sessionId + "\r\n";
            string message = requestLine + cseqLine + sessionLine;
            byte[] messageBytes = System.Text.Encoding.ASCII.GetBytes(message);
            _RTSPSocket.Send(messageBytes);
            timer.Stop();
        }

        internal void button_teardown_click(object sender, EventArgs e)
        {
            string requestLine = "TEARDOWN rtsp://" + _view.getIpAddress() + ":" + _view.getPortNumber() + "/" + _view.getVideoName() + " RTSP/1.0\r\n";
            string cseqLine = "CSeq: " + cseq++ + "\r\n";
            string sessionLine = "Session: " + sessionId + "\r\n";
            string message = requestLine + cseqLine + sessionLine;
            byte[] messageBytes = System.Text.Encoding.ASCII.GetBytes(message);
            _RTSPSocket.Send(messageBytes);
            _RTPmodel.close();
            _view.wipeFrame();
            timer.Stop();
        }
    }
}
