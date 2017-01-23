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
        int careerInput = 0, houseInput = 0, numberOfKidsInput = 0;
        int petsInput = 0, vehicleInput = 0, incomeInput = 0;

        #region User input variables
        //creating variables for all user inputs
        string career1, career2, career3, career4;
        string house1, house2, house3, house4;
        string numberOfKids1, numberOfKids2, numberOfKids3, numberOfKids4;
        string pets1, pets2, pets3, pets4;
        string vehicle1, vehicle2, vehicle3, vehicle4;
        string income1, income2, income3, income4;
        #endregion

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
            #region Making the labels and inputs visible
            //clearing the starting screen
            startButton.Visible = false;
            titleLabel.Visible = false;
            this.BackColor = Color.White;
            outputLabel1.Text = "Please input your options for each category";
            //bringing up category inputs
            careerLabel1.Visible = true;
            careerInput1.Visible = true;
            careerInput2.Visible = true;
            careerInput3.Visible = true;
            careerInput4.Visible = true;

            houseLabel.Visible = true;
            houseInput1.Visible = true;
            houseInput2.Visible = true;
            houseInput3.Visible = true;
            houseInput4.Visible = true;

            numberOfKidsLabel.Visible = true;
            numberOfKidsInput1.Visible = true;
            numberOfKidsInput2.Visible = true;
            numberOfKidsInput3.Visible = true;
            numberOfKidsInput4.Visible = true;

            petsLabel.Visible = true;
            petsInput1.Visible = true;
            petsInput2.Visible = true;
            petsInput3.Visible = true;
            petsInput4.Visible = true;

            vehicleLabel.Visible = true;
            vehicleInput1.Visible = true;
            vehicleInput2.Visible = true;
            vehicleInput3.Visible = true;
            vehicleInput4.Visible = true;

            incomeLabel.Visible = true;
            incomeInput1.Visible = true;
            incomeInput2.Visible = true;
            incomeInput3.Visible = true;
            incomeInput4.Visible = true;

            blueBox.Image = null;
            yellowBox.Image = null;
            greenBox.Image = null;
            //greenBox.Hide();
            //yellowBox.Hide();
            //greenLabel.Hide();
            //yellowLabel.Hide();
            nextButton.Visible = true;
            #endregion
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            #region Convert user inputs to string values and count number of inputs
            //assigning the user inputs to values to be used later
            career1 = careerInput1.Text;
            //careerInput = careerInput + 1;
            career2 = careerInput2.Text;
            //careerInput = careerInput + 1;
            career3 = careerInput3.Text;
            //careerInput = careerInput + 1;
            career4 = careerInput4.Text;
            //careerInput = careerInput + 1;

            house1 = houseInput1.Text;
            //houseInput = houseInput + 1;
            house2 = houseInput2.Text;
            //houseInput = houseInput + 1;
            house3 = houseInput3.Text;
            //houseInput = houseInput + 1;
            house4 = houseInput4.Text;
            //houseInput = houseInput + 1;

            numberOfKids1 = numberOfKidsInput1.Text;
            //numberOfKidsInput = numberOfKidsInput + 1;
            numberOfKids2 = numberOfKidsInput2.Text;
            //numberOfKidsInput = numberOfKidsInput + 1;
            numberOfKids3 = numberOfKidsInput3.Text;
            //numberOfKidsInput = numberOfKidsInput + 1;
            numberOfKids4 = numberOfKidsInput4.Text;
            //numberOfKidsInput = numberOfKidsInput + 1;

            pets1 = petsInput1.Text;
            //petsInput = petsInput + 1;
            pets2 = petsInput2.Text;
            //petsInput = petsInput + 1;
            pets3 = petsInput3.Text;
            //petsInput = petsInput + 1;
            pets4 = petsInput4.Text;
            //petsInput = petsInput + 1;
/
            vehicle1 = vehicleInput1.Text;
            //vehicleInput = vehicleInput + 1;
            vehicle2 = vehicleInput2.Text;
            //vehicleInput = vehicleInput + 1;
            vehicle3 = vehicleInput3.Text;
            //vehicleInput = vehicleInput + 1;
            vehicle4 = vehicleInput4.Text;
            //vehicleInput = vehicleInput + 1;

            income1 = incomeInput1.Text;
            //incomeInput = incomeInput + 1;
            income2 = incomeInput2.Text;
            //incomeInput = incomeInput + 1;
            income3 = incomeInput3.Text;
            //incomeInput = incomeInput + 1;
            income4 = incomeInput4.Text;
            //incomeInput = incomeInput + 1;

           // careerInput = careerInput;

            #endregion

            #region Making input boxes and labels invisible
            careerLabel1.Visible = false;
            careerInput1.Visible = false;
            careerInput2.Visible = false;
            careerInput3.Visible = false;
            careerInput4.Visible = false;

            houseLabel.Visible = false;
            houseInput1.Visible = false;
            houseInput2.Visible = false;
            houseInput3.Visible = false;
            houseInput4.Visible = false;

            numberOfKidsLabel.Visible = false;
            numberOfKidsInput1.Visible = false;
            numberOfKidsInput2.Visible = false;
            numberOfKidsInput3.Visible = false;
            numberOfKidsInput4.Visible = false;

            petsLabel.Visible = false;
            petsInput1.Visible = false;
            petsInput2.Visible = false;
            petsInput3.Visible = false;
            petsInput4.Visible = false;

            vehicleLabel.Visible = false;
            vehicleInput1.Visible = false;
            vehicleInput2.Visible = false;
            vehicleInput3.Visible = false;
            vehicleInput4.Visible = false;

            incomeLabel.Visible = false;
            incomeInput1.Visible = false;
            incomeInput2.Visible = false;
            incomeInput3.Visible = false;
            incomeInput4.Visible = false;
            #endregion

             

            this.Refresh();
            titleLabel.Text = "Before the game start, we would like you to answer some questions.";
          
            nextButton.Text = "Continue";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int scene = 0;  // tracks what part of the game the user is at
            Random randGen = new Random();
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.B)       //green button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    this.Close();
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    this.Close();
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 8;
                }
                else if (scene == 9)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    this.Close();
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    this.Close();
                }

            }
            else if (e.KeyCode == Keys.N)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    this.Close();
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    this.Close();
                }
                else if (scene == 6)
                {
                    scene = 9;
                }
                else if (scene == 8)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    this.Close();
                }
                else if (scene == 9)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    this.Close();
                }

            }
            else if (e.KeyCode == Keys.M)  //yellow button press
            {
                if (scene == 0)
                {
                    scene = 3;
                }
            }
        }
    }
}
