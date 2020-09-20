using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPillar
{
    public partial class MainForm : Form
    {
        private TextBox[] pillars = new TextBox[5];
        private Button[] buttons = new Button[5];

        private List<NumberDroplet> droplets;
        private int counter;
        private string keyword;

        public MainForm()
        {
            InitializeComponent();

            pillars[0] = pillar1; buttons[0] = button1;
            pillars[1] = pillar2; buttons[1] = button2;
            pillars[2] = pillar3; buttons[2] = button3;
            pillars[3] = pillar4; buttons[3] = button4;
            pillars[4] = pillar5; buttons[4] = button5;

            logBox.Text = "A = 2\nB = 3\nC = 5\nD = 7\nE = 11\nF = 13\nG = 17\nH = 19\nI = 23\nJ = 29\nK = 31\nL = 37\nM = 41\nN = 43\nO = 47\nP = 53\nQ = 59\nR = 61\nS = 67\nT = 71\nU = 73\nV = 79\nW = 83\nX = 89\nY = 97\nZ = 101".Replace("\n", "\r\n");
        }

        private void minBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void speedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;

            int minInt = int.Parse(minBox.Text);
            int maxInt = int.Parse(maxBox.Text);
            int bpm = int.Parse(speedBox.Text);

            if (bpm < 6)
            {
                dr = MessageBox.Show("Speed lower than 6 is too slow for the challenge. Are you sure?", "Warning", MessageBoxButtons.YesNo);
            }

            if (bpm > 120)
            {
                dr = MessageBox.Show("Speed higher than 120 might be too fast for the challenge - this is not a rhythm game! Are you sure?", "Warning", MessageBoxButtons.YesNo);
            }

            if (dr.Equals(DialogResult.Yes))
            {
                PrimeBox box = new PrimeBox(minInt, maxInt, bpm);

                if (box.Primes == null)
                {
                    MessageBox.Show("Fatal error - the range does not contain enough primes - should be at least 26!", "Error");
                    return;
                }

                PerformChallenge(box);
            }
        }

        private void PerformChallenge(PrimeBox box)
        {
            for (int i=0; i<pillars.Count(); i++)
            {
                pillars[i].Text = "";
            }

            keyword = "truongtrunghocphothongchuyenhanoiamsterdam";

            int minute = 2;
            droplets = box.GetSequence(keyword, minute);

            gameTimer.Interval = minute * 60000 / droplets.Count();
            timeBar.Minimum = 0;
            timeBar.Maximum = droplets.Count();
            timeBar.Value = timeBar.Maximum;
            counter = 0;

            gameTimer.Start();
            submitButton.Enabled = true;
            startButton.Enabled = false;
            minBox.Enabled = false;
            maxBox.Enabled = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (droplets[counter].PillarId != -1)
            {
                for (int i=0; i<pillars.Count(); i++)
                {
                    if (i == droplets[counter].PillarId) pillars[i].Text = droplets[counter].Value.ToString() + Environment.NewLine + Environment.NewLine + pillars[i].Text;
                    else pillars[i].Text = Environment.NewLine + Environment.NewLine + Environment.NewLine + pillars[i].Text;
                }
            }
            counter++;
            timeBar.Value--;

            if (counter >= droplets.Count()) gameTimer.Stop();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (answerBox.Text.ToUpper().Equals(keyword.ToUpper())) MessageBox.Show("Correct!");
            else MessageBox.Show("Wrong answer!" + Environment.NewLine + "Actual keyword: " + keyword.ToUpper());

            startButton.Enabled = true;
            submitButton.Enabled = false;
            minBox.Enabled = true;
            maxBox.Enabled = true;
        }
    }
}
