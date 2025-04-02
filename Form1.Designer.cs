namespace darthorizon_music_player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(-1, -2);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(960, 426);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(656, 368);
            button1.Name = "button1";
            button1.Size = new Size(59, 56);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = Properties.Resources.play;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(112, 364);
            button2.Name = "button2";
            button2.Size = new Size(101, 60);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImage = Properties.Resources.pause;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(219, 364);
            button3.Name = "button3";
            button3.Size = new Size(101, 60);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(721, 368);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(109, 56);
            button5.TabIndex = 6;
            button5.TextAlign = ContentAlignment.TopLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.irina_savchishina_cassette_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.irina_savchishina_tape_1;
            pictureBox1.Location = new Point(-12, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(988, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(959, 430);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(axWindowsMediaPlayer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DH MUSİC PLAYER";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
    }
}
