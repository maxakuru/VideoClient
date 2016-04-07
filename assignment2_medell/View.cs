using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_medell
{
    public partial class View : Form
    {
        Controller _controller;

        public View()
        {
            InitializeComponent();
            _controller = new Controller();
            this.textBox_packetReport.ScrollBars = ScrollBars.Vertical;
            this.textBox_packetReport.ReadOnly = true;
            this.textBox_serverResponse.ScrollBars = ScrollBars.Vertical;
            this.textBox_serverResponse.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            button_setup.Enabled = true;
            _controller.button_connect_Click(sender, e);
        }

        internal void Disable_ConnectButton()
        {
            this.button_connect.Enabled = false;
            this.button_setup.Enabled = true;
        }

        
        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            //if ((this.pictureBox.Bounds.Contains(e.Location) || this.pictureBox_pause.Bounds.Contains(e.Location)) 
                //&& !this.pictureBox_pause.Visible)
                //this.pictureBox_pause.Show();
        }

        private void pictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            Point relativept = groupBox1.PointToClient(Cursor.Position);
            Rectangle rect = new Rectangle(pictureBox_setup.Bounds.X, 
                pictureBox_pause.Bounds.Y+5,
                pictureBox_teardown.Bounds.X+pictureBox_teardown.Width-pictureBox_setup.Bounds.X,
                pictureBox_setup.Bounds.Height);
            //this keeps the picture buttons from disappearing when the picturebox loses the mouse hover
            if(!rect.Contains(relativept))
            {
                this.pictureBox_play.Visible = false;
                this.pictureBox_setup.Visible = false;
                this.pictureBox_teardown.Visible = false;
                this.pictureBox_pause.Visible = false;
            }
        }

        private void pictureBox_MouseHover(object sender, System.EventArgs e)
        {
            //on hover over the video, show picture buttons
            this.pictureBox_pause.Visible = true;
            this.pictureBox_play.Visible = true;
            this.pictureBox_setup.Visible = true;
            this.pictureBox_teardown.Visible = true;
        }

        private void pictureBox_setup_Click(object sender, EventArgs e)
        {
            if(button_setup.Enabled)
                this.button_setup_Click(sender, e);
        }

        private void pictureBox_play_Click(object sender, EventArgs e)
        {
            if (button_play.Enabled)
                this.button_play_Click(sender, e);
        }

        private void pictureBox_pause_Click(object sender, EventArgs e)
        {
            if (button_pause.Enabled)
                this.button_pause_Click(sender, e);
        }

        private void pictureBox_teardown_Click(object sender, EventArgs e)
        {
            if (button_teardown.Enabled)
                this.button_teardown_Click(sender, e);
        }

        internal string getPortNumber()
        {
            return textBox_port.Text;
        }

        internal string getIpAddress()
        {
            return textBox_ip.Text;
        }

        private void button_setup_Click(object sender, EventArgs e)
        {
            button_setup.Enabled = false;
            button_play.Enabled = true;
            button_teardown.Enabled = true;
            textBox_ip.ReadOnly = true;
            textBox_port.ReadOnly = true;
            textBox_videoName.ReadOnly = true;
            _controller.button_setup_click(sender, e);
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            button_play.Enabled = false;
            button_pause.Enabled = true;
            _controller.button_play_click(sender, e);
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            button_play.Enabled = true;
            button_pause.Enabled = false;
            _controller.button_pause_click(sender, e);
        }

        private void button_teardown_Click(object sender, EventArgs e)
        {
            button_play.Enabled = false;
            button_setup.Enabled = true;
            button_teardown.Enabled = false;
            textBox_ip.ReadOnly = false;
            textBox_port.ReadOnly = false;
            textBox_videoName.ReadOnly = false;
            _controller.button_teardown_click(sender, e);
        }

        internal string getVideoName()
        {
            return textBox_videoName.Text;
        }

        delegate void SetInfoCallback(string info);

        internal void SetServerBox(string _msg)
        {
            string text = _msg;
            SetInfoCallback d = new SetInfoCallback(add_server_text);
            this.Invoke(d, new Object[] { text });
        }

        public void add_server_text(String _msg)
        {
            this.textBox_serverResponse.Text += _msg;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void putFrame(Bitmap bmp)
        {
            //Bitmap i = new Bitmap(bmp, pictureBox.Size);
            pictureBox.Image = (Image)new Bitmap(bmp, pictureBox.Size);
        }

        internal void wipeFrame()
        {
            pictureBox.Image = null;
        }

        internal bool printHeader()
        {
            return checkBox_printHeader.Checked;
        }

        internal bool packetReport()
        {
            return checkBox_packetReport.Checked;
        }

        internal void SetInfoBox(string p)
        {
            string text = p;
            SetInfoCallback d = new SetInfoCallback(add_text);
            this.Invoke(d, new Object[] { text });
        }

        public void add_text(String _msg)
        {
            this.textBox_packetReport.Text += _msg;
        }
    }
}
