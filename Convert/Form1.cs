//Student: Barbara Sullivan
//Instructor: Dr. Jerry Mamo
//Class: CIST 2341 – C# Programming – 60485 – Summer 2019
//Lab #2 – Assign 2 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert
{
    public partial class Form1 : Form
    {
        //declare variables
        double celsius = 0;
        double fahr = 0;

        public Form1()
        {
            InitializeComponent();
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FahrTxtB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CelsiusTxtB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempLbl.Text = String.Empty;
        }

        //Enable Fahrenheit TextBox to be active when RadioButton Fahr to Celsius, display and change title according to the RadioButton selected
        private void FtoCRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (FtoCRbtn.Checked == true)
            {
                FahrTxtB.Enabled = true;
                CelsiusTxtB.Enabled = false;
                this.Text = "Fahrenheit to Celsius";
                tempLbl.Text = "Fahrenheit to Celsius";
            }
        }

        private void CtoFRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CtoFRbtn.Checked == true)
            {
                FahrTxtB.Enabled = false;
                CelsiusTxtB.Enabled = true;
                this.Text = "Celsius to Fahrenheit";
                tempLbl.Text = "Celsius to Fahrenheit";

            }
        }

        //Calculate temperatures and display on the appropriate TextBox
        private void ConvBtn_Click(object sender, EventArgs e)
        {
            if (CelsiusTxtB.Text != "" && CtoFRbtn.Checked == true)
            {
                celsius = int.Parse(CelsiusTxtB.Text);
                fahr = (celsius * 9) / 5 + 32;
                FahrTxtB.Text = fahr.ToString("0.##");
                
                
            }
            else if (FahrTxtB.Text != "" && FtoCRbtn.Checked == true)
            {
                fahr = int.Parse(FahrTxtB.Text);
                celsius = (fahr - 32) * 5 / 9;
                CelsiusTxtB.Text = celsius.ToString("0.##");
                
            }
            //Display a warning when nothing is typed on The appropriate TextBox
            else if (FahrTxtB.Text == "" && CelsiusTxtB.Text == "")
            {
                MessageBox.Show("You forgot to enter a temperature. Please enter a temperature.");
            }

        }

        //Close the application when Exit Button is clicked
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear TextBoxes when Clear Button is clicked
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CelsiusTxtB.Text = String.Empty;
            FahrTxtB.Text = String.Empty;
        }
    }
}
