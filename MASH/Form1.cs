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
            outputLabel1.Text = "Please input your options for each category";
            //bringing up category inputs
            careerLabel1.Visible = true;
            career1.Visible = true;
            career2.Visible = true;
            career3.Visible = true;
            career4.Visible = true;

            houseLabel.Visible = true;
            house1.Visible = true;
            house2.Visible = true;
            house3.Visible = true;
            house4.Visible = true;

            numberOfKidsLabel.Visible = true;
            numberOfKids1.Visible = true;
            numberOfKids2.Visible = true;
            numberOfKids3.Visible = true;
            numberOfKids4.Visible = true;

            petsLabel.Visible = true;
            pets1.Visible = true;
            pets2.Visible = true;
            pets3.Visible = true;
            pets4.Visible = true;

            vehicleLabel.Visible = true;
            vehicle1.Visible = true;
            vehicle2.Visible = true;
            vehicle3.Visible = true;
            vehicle4.Visible = true;

            incomeLabel.Visible = true;
            income1.Visible = true;
            income2.Visible = true;
            income3.Visible = true;
            income4.Visible = true;

            nextButton.Visible = true;
        }
        //new change for commit and sync
        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
