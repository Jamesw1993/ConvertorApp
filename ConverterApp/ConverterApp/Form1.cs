using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    // This program was written by Gail Mosdell - Modified by James Watson
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
{
    public partial class frm_Main : Form
    {

        public frm_Main()
        {
            InitializeComponent();
        }
              
        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;
        // Array for storing strings that displays the results of each conversion
        string[] Results = new string[5];

        // I am only going to comment the CM_TO_INCH_CON and C_TO_F_CON functions as the others are copies with different conversion rates

        // Centimetres to inch conversion function
        private void CM_TO_INCH_CON()
        {
            // Conversion rate
            const double CM_TO_INCH = 0.3937;
            
            if (!double.TryParse(txt_CM_to_Inches.Text, out dbl_UofM)) //if not double then try to parse to double dbl_UofM, Neccessary to convert string to double.
            {
                MessageBox.Show("Centimetres to Inches: A numeric must be entered. Please re-enter the value."); // Fail box
                Results[0] = null; //sets result to null to avoid repeating results
                txt_CM_to_Inches.Clear(); // clears the relevant textbox
                txt_CM_to_Inches.Focus(); // Focus on the relevant textbox               
            }
            else
            {
                // Calculation
                dbl_Convert = dbl_UofM * CM_TO_INCH;
                // Display Results to listbox
                Results[0] = (txt_CM_to_Inches.Text + " centimetres is " + dbl_Convert + " inches. ");
            }
        }

        // Metres to feet conversion function
        private void M_TO_FEET_CON()
        {
            const double M_to_Feet = 3.28084;

            if (!double.TryParse(txt_M_to_Feet.Text, out dbl_UofM))
            {
                MessageBox.Show("Metres to Feet: A numeric must be entered. Please re-enter the value.");
                Results[1] = null;
                txt_M_to_Feet.Clear();
                txt_M_to_Feet.Focus();               
            }
            else
            {
                dbl_Convert = dbl_UofM * M_to_Feet;
                Results[1] = (txt_M_to_Feet.Text + " metres is " + dbl_Convert + " feet. ");
            }
        }

        // Celsius to Farenheit function
        private void C_to_F_CON()
        {
            //No conversion constant because hardcoded values in calculation

            if (!double.TryParse(txt_Celsius_to_Farenheit.Text, out dbl_UofM))
            {

                MessageBox.Show("Celisus to Farenheit: A numeric must be entered. Please re-enter the value.");
                Results[2] = null;
                txt_Celsius_to_Farenheit.Clear();
                txt_Celsius_to_Farenheit.Focus();
            }
            else
            {
                //Calculation, hardcoded values because its hard.
                dbl_Convert = dbl_UofM * 9.0 / 5.0 + 32;
                Results[2] = (txt_Celsius_to_Farenheit.Text + " degrees Celsius is " + dbl_Convert + " degrees Farenheit. ");
            }
        }

        private void CM_TO_FEET_CON()
        {
            const double CM_to_Feet = 0.0328084;

            if (!double.TryParse(txt_Centimetres_to_Feet.Text, out dbl_UofM))
            {
                MessageBox.Show("Centimetres to Feet: A numeric must be entered. Please re-enter the value.");
                Results[3] = null;
                txt_Centimetres_to_Feet.Clear();
                txt_Centimetres_to_Feet.Focus();           
            }
            else
            {
                dbl_Convert = dbl_UofM * CM_to_Feet;
                Results[3] = (txt_Centimetres_to_Feet.Text + " centimetres is " + dbl_Convert + " feet. ");
            }
        }

        private void KM_TO_MILES_CON()
        {
            const double Kilometres_to_Miles = 0.621371;

            if (!double.TryParse(txt_Kilometres_to_Miles.Text, out dbl_UofM))
            {
                MessageBox.Show("Kilometres to Miles: A numeric must be entered. Please re-enter the value.");
                Results[4] = null;
                txt_Kilometres_to_Miles.Clear();
                txt_Kilometres_to_Miles.Focus();                
            }
            else
            {
                dbl_Convert = dbl_UofM * Kilometres_to_Miles;
                Results[4] = (txt_Kilometres_to_Miles.Text + " kilometres is " + dbl_Convert + " miles. ");
            }
        }

        // Button to exit the application
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Button that clears all text boxs and the list box
        private void btn_Clear_all_Click(object sender, EventArgs e)
        {
            lb_Results.Items.Clear();
            txt_Celsius_to_Farenheit.Clear();
            txt_Centimetres_to_Feet.Clear();
            txt_CM_to_Inches.Clear();
            txt_Kilometres_to_Miles.Clear();
            txt_M_to_Feet.Clear();
        }

        //Button that starts all of the conversion methods
        private void btn_Convert_All_Click(object sender, EventArgs e)
        {
            // Clears the listbox and runs the conversion functions
            lb_Results.Items.Clear();
            CM_TO_INCH_CON();
            M_TO_FEET_CON();
            C_to_F_CON();
            CM_TO_FEET_CON();
            KM_TO_MILES_CON();


            // count loop that sends the results of each function to the listbox 
            int count = 0;
            while (count <= 4)
            {
                // If the input is empty then the conversions result is null and will not be displayed
                if (Results[count] != null)
                {
                    lb_Results.Items.Add(Results[count]);
                }
                count++;
            }
        }
    }
}
