namespace Codingtracker
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private TimeSpan codingtime { get; set; }
        public Form1()
        {
            startTime = DateTime.Now;
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            formTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            timerLabel.Text = "00:00";
            
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            var span = DateTime.Now - startTime;
            codingtime = span;
            timerLabel.Text = $"{span.Minutes:00}:{span.Seconds:00}";

        }
    }
}
