using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      //  private void button1_Click(object sender, EventArgs 

            //change 1

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //clearing the starting screen
            startButton.Visible = false;
            titleLabel.Visible = false;

            this.BackColor = Color.White;
        }
    }
}
