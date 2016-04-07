namespace assignment2_medell
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_videoName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_teardown = new System.Windows.Forms.PictureBox();
            this.pictureBox_setup = new System.Windows.Forms.PictureBox();
            this.pictureBox_pause = new System.Windows.Forms.PictureBox();
            this.pictureBox_play = new System.Windows.Forms.PictureBox();
            this.button_teardown = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_setup = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_packetReport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_serverResponse = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.checkBox_packetReport = new System.Windows.Forms.CheckBox();
            this.checkBox_printHeader = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_teardown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_setup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect to Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(172, 33);
            this.textBox_port.MaxLength = 5;
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 26);
            this.textBox_port.TabIndex = 1;
            this.textBox_port.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server IP address:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(476, 30);
            this.textBox_ip.MaxLength = 15;
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 26);
            this.textBox_ip.TabIndex = 3;
            this.textBox_ip.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Video name:";
            // 
            // textBox_videoName
            // 
            this.textBox_videoName.Location = new System.Drawing.Point(736, 32);
            this.textBox_videoName.Name = "textBox_videoName";
            this.textBox_videoName.Size = new System.Drawing.Size(100, 26);
            this.textBox_videoName.TabIndex = 5;
            this.textBox_videoName.Text = "video1.mjpeg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_teardown);
            this.groupBox1.Controls.Add(this.pictureBox_setup);
            this.groupBox1.Controls.Add(this.pictureBox_pause);
            this.groupBox1.Controls.Add(this.pictureBox_play);
            this.groupBox1.Controls.Add(this.button_teardown);
            this.groupBox1.Controls.Add(this.button_pause);
            this.groupBox1.Controls.Add(this.button_play);
            this.groupBox1.Controls.Add(this.button_setup);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(46, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 572);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_teardown
            // 
            this.pictureBox_teardown.Image = global::assignment2_medell.Properties.Resources.Teardown;
            this.pictureBox_teardown.Location = new System.Drawing.Point(558, 380);
            this.pictureBox_teardown.Name = "pictureBox_teardown";
            this.pictureBox_teardown.Size = new System.Drawing.Size(63, 50);
            this.pictureBox_teardown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_teardown.TabIndex = 9;
            this.pictureBox_teardown.TabStop = false;
            this.pictureBox_teardown.Visible = false;
            this.pictureBox_teardown.Click += new System.EventHandler(this.pictureBox_teardown_Click);
            // 
            // pictureBox_setup
            // 
            this.pictureBox_setup.Image = global::assignment2_medell.Properties.Resources.Setup;
            this.pictureBox_setup.Location = new System.Drawing.Point(157, 380);
            this.pictureBox_setup.Name = "pictureBox_setup";
            this.pictureBox_setup.Size = new System.Drawing.Size(59, 50);
            this.pictureBox_setup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_setup.TabIndex = 12;
            this.pictureBox_setup.TabStop = false;
            this.pictureBox_setup.Visible = false;
            this.pictureBox_setup.Click += new System.EventHandler(this.pictureBox_setup_Click);
            // 
            // pictureBox_pause
            // 
            this.pictureBox_pause.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pause.Image = global::assignment2_medell.Properties.Resources.Pause;
            this.pictureBox_pause.Location = new System.Drawing.Point(415, 380);
            this.pictureBox_pause.Name = "pictureBox_pause";
            this.pictureBox_pause.Size = new System.Drawing.Size(64, 50);
            this.pictureBox_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pause.TabIndex = 10;
            this.pictureBox_pause.TabStop = false;
            this.pictureBox_pause.Visible = false;
            this.pictureBox_pause.Click += new System.EventHandler(this.pictureBox_pause_Click);
            // 
            // pictureBox_play
            // 
            this.pictureBox_play.Image = global::assignment2_medell.Properties.Resources.Play;
            this.pictureBox_play.Location = new System.Drawing.Point(288, 380);
            this.pictureBox_play.Name = "pictureBox_play";
            this.pictureBox_play.Size = new System.Drawing.Size(61, 50);
            this.pictureBox_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_play.TabIndex = 11;
            this.pictureBox_play.TabStop = false;
            this.pictureBox_play.Visible = false;
            this.pictureBox_play.Click += new System.EventHandler(this.pictureBox_play_Click);
            // 
            // button_teardown
            // 
            this.button_teardown.Enabled = false;
            this.button_teardown.Location = new System.Drawing.Point(658, 448);
            this.button_teardown.Name = "button_teardown";
            this.button_teardown.Size = new System.Drawing.Size(115, 111);
            this.button_teardown.TabIndex = 4;
            this.button_teardown.Text = "Teardown";
            this.button_teardown.UseVisualStyleBackColor = true;
            this.button_teardown.Click += new System.EventHandler(this.button_teardown_Click);
            // 
            // button_pause
            // 
            this.button_pause.Enabled = false;
            this.button_pause.Location = new System.Drawing.Point(442, 448);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(114, 112);
            this.button_pause.TabIndex = 3;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(223, 448);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(116, 112);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_setup
            // 
            this.button_setup.Enabled = false;
            this.button_setup.Location = new System.Drawing.Point(6, 448);
            this.button_setup.Name = "button_setup";
            this.button_setup.Size = new System.Drawing.Size(114, 112);
            this.button_setup.TabIndex = 1;
            this.button_setup.Text = "Setup";
            this.button_setup.UseVisualStyleBackColor = true;
            this.button_setup.Click += new System.EventHandler(this.button_setup_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(767, 427);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // textBox_packetReport
            // 
            this.textBox_packetReport.Location = new System.Drawing.Point(52, 676);
            this.textBox_packetReport.Multiline = true;
            this.textBox_packetReport.Name = "textBox_packetReport";
            this.textBox_packetReport.ReadOnly = true;
            this.textBox_packetReport.Size = new System.Drawing.Size(651, 169);
            this.textBox_packetReport.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 881);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server Responses:";
            // 
            // textBox_serverResponse
            // 
            this.textBox_serverResponse.Location = new System.Drawing.Point(52, 918);
            this.textBox_serverResponse.Multiline = true;
            this.textBox_serverResponse.Name = "textBox_serverResponse";
            this.textBox_serverResponse.ReadOnly = true;
            this.textBox_serverResponse.Size = new System.Drawing.Size(651, 182);
            this.textBox_serverResponse.TabIndex = 9;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(736, 973);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(109, 35);
            this.button_connect.TabIndex = 10;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(736, 1037);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(109, 29);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // checkBox_packetReport
            // 
            this.checkBox_packetReport.AutoSize = true;
            this.checkBox_packetReport.Location = new System.Drawing.Point(736, 717);
            this.checkBox_packetReport.Name = "checkBox_packetReport";
            this.checkBox_packetReport.Size = new System.Drawing.Size(137, 24);
            this.checkBox_packetReport.TabIndex = 12;
            this.checkBox_packetReport.Text = "Packet Report";
            this.checkBox_packetReport.UseVisualStyleBackColor = true;
            // 
            // checkBox_printHeader
            // 
            this.checkBox_printHeader.AutoSize = true;
            this.checkBox_printHeader.Location = new System.Drawing.Point(736, 765);
            this.checkBox_printHeader.Name = "checkBox_printHeader";
            this.checkBox_printHeader.Size = new System.Drawing.Size(124, 24);
            this.checkBox_printHeader.TabIndex = 13;
            this.checkBox_printHeader.Text = "Print Header";
            this.checkBox_printHeader.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 1130);
            this.Controls.Add(this.checkBox_printHeader);
            this.Controls.Add(this.checkBox_packetReport);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_serverResponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_packetReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_videoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.View_MouseMove);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_teardown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_setup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_videoName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_teardown;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_setup;
        private System.Windows.Forms.TextBox textBox_packetReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_serverResponse;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.CheckBox checkBox_packetReport;
        private System.Windows.Forms.CheckBox checkBox_printHeader;
        private System.Windows.Forms.PictureBox pictureBox_setup;
        private System.Windows.Forms.PictureBox pictureBox_play;
        private System.Windows.Forms.PictureBox pictureBox_pause;
        private System.Windows.Forms.PictureBox pictureBox_teardown;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

