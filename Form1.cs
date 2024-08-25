using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CSC240_06_02_FiveColors2_DSG
{
    public partial class UxForm1 : Form
    {
        public UxForm1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Black;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Green;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Blue;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            RecursiveClearTextBoxes(this.Controls);
            this.Controls.Clear();
            this.InitializeComponent();
            BackColor = DefaultBackColor;
        }

        private void RecursiveClearTextBoxes(Control.ControlCollection cc)
        {
            if (radWhite.Checked)
            {
                radWhite.Checked = false;
            }
            if (radBlack.Checked)
            {
                radBlack.Checked = false;
            }
            if (radRed.Checked)
            {
                radRed.Checked = false;
            }
            if (radGreen.Checked)
            {
                radGreen.Checked = false;
            }
            if (radBlue.Checked)
            {
                radBlue.Checked = false;
            }
        }
    }
}
