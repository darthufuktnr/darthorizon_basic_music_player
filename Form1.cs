namespace darthorizon_music_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
               // label1.Text = openFileDialog1.FileName;

                
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.uiMode = "none";
        }
    }
}
