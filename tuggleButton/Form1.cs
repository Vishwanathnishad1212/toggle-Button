using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuggleButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        bool _perform = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (_perform == false)
            {
                button1.Text = "Switch On";
                pictureBox1.Image = Properties.Resources.SwitchOn;
                _perform = true;
            }
            else
            {
                button1.Text = "Switch Off";
                pictureBox1.Image = Properties.Resources.SwitchOff;
                _perform = false;
            }
        }
    }
}
