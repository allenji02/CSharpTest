namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IPlayer iplayer;
        AVI avi;
        MP3 mp3;

        private void mp3Button_Click(object sender, EventArgs e)
        {
            if (mp3 == null)
            {
                mp3 = new MP3();
            }
            iplayer = mp3;
        }

        private void aviButton_Click(object sender, EventArgs e)
        {
            if (avi == null)
            {
                avi = new AVI();
            }
            iplayer = avi;
        }

        private void preButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = iplayer.Pre();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = iplayer.Stop();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = iplayer.Play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = iplayer.Pause();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = iplayer.Next();
        }
    }
}