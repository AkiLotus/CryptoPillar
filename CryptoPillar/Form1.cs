using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPillar
{
    public partial class MainForm : Form
    {
        TextBox[] pillars = new TextBox[5];
        Button[] buttons = new Button[5];
        public MainForm()
        {
            InitializeComponent();

            pillars[0] = pillar1; buttons[0] = button1;
            pillars[1] = pillar2; buttons[1] = button2;
            pillars[2] = pillar3; buttons[2] = button3;
            pillars[3] = pillar4; buttons[3] = button4;
            pillars[4] = pillar5; buttons[4] = button5;
        }
    }
}
