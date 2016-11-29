//Name:    Jeremy Brown
//Date:    10/21/2011
//Class:   CIS 199-01
//Purpose: The purpose of this program is to determine the date and time of registration for classes
//         for new and continuing students for the upcoming school semester.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project2
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double hours;//Used to store the hours entered by the user
            double time;//Used to store and display the time of registration based on the user's input
            string date ;//Used to store and display the date of registration based on the user's input
            string lastName;//Used to store the last name of the user
            string messageBox;//Used to store the message that will later be outputted by the message box.
            char firstLetter;//Used to store the first letter of the last name in char format
            const double SENIOR = 90;//used to store the constant of how many hours is considered a senior
            const double JUNIOR = 60;//used to store the constant of how many hours is considered a junior
            const double SOPHMORE = 30;//used to store the constant of how many hours is considered a sophomore
            const string SENIORDATE = "11/07/2011";//Used to store the senior date of registration
            const string JUNIOR_DATE = "11/08/2011";//Used to store the junior date of registration
            const string SOPHOMORE_DATE_1 = "11/09/2011";//Used to store the first sophomore date of registration
            const string SOPHOMORE_DATE_2 = "11/10/2011";//Used to store the second sophomore date of registration
            const string FRESHMAN_DATE_1 = "11/11/2011";//Used to store the first freshman date of registration
            const string FRESHMAN_DATE_2 = "11/14/2011";//Used to store the second freshman date of registration
            hours = Convert.ToInt32(creditHourTxt.Text);
            lastName = Convert.ToString(lastNameTxt.Text);
            lastName = lastName.Substring(0, 1);
            lastName = lastName.ToLower();
            firstLetter = Convert.ToChar(lastName);

            if (hours >= SENIOR)//Determines if the user is a senior
                if (firstLetter >= 'e' && firstLetter <= 'i')
                {
                    time = 8;
                    date = SENIORDATE;
                }
                else if (firstLetter >= 'j' && firstLetter <= 'o')
                {
                    time = 10;
                    date = SENIORDATE;
                }
                else if (firstLetter >= 'p' && firstLetter <= 't')
                {
                    time = 12;
                    date = SENIORDATE;
                }
                else if (firstLetter >= 'u' && firstLetter <= 'z')
                {
                    time = 2;
                    date = SENIORDATE;
                }

                else
                {
                    time = 4;
                    date = SENIORDATE;
                }


            else if (hours >= JUNIOR)//Determines if the user is a junior
                if (firstLetter >= 'e' && firstLetter <= 'i')
                {
                    time = 8;
                    date = JUNIOR_DATE;
                }
                else if (firstLetter >= 'j' && firstLetter <= 'o')
                {
                    time = 10;
                    date = JUNIOR_DATE;
                }
                else if (firstLetter >= 'p' && firstLetter <= 't')
                {
                    time = 12;
                    date = JUNIOR_DATE;
                }
                else if (firstLetter >= 'u' && firstLetter <= 'z')
                {
                    time = 2;
                    date = JUNIOR_DATE;
                }

                else
                {
                    time = 4;
                    date = JUNIOR_DATE;
                }
            else if (hours >= SOPHMORE)//Determines if the user is a sophomore
                if (firstLetter >= 'e' && firstLetter <= 'f')
                {
                    time = 8;
                    date = SOPHOMORE_DATE_1;
                }
                else if (firstLetter >= 'g' && firstLetter <= 'i')
                {
                    time = 10;
                    date = SOPHOMORE_DATE_1;
                }
                else if (firstLetter >= 'j' && firstLetter <= 'l')
                {
                    time = 12;
                    date = SOPHOMORE_DATE_1;
                }
                else if (firstLetter >= 'm' && firstLetter <= 'o')
                {
                    time = 2;
                    date = SOPHOMORE_DATE_1;
                }

                else if (firstLetter >= 'p' && firstLetter <= 'r')
                {
                    time = 4;
                    date = SOPHOMORE_DATE_1;
                }
                else if (firstLetter >= 's' && firstLetter <= 't')
                {
                    time = 8;
                    date = SOPHOMORE_DATE_2;
                }
                else if (firstLetter >= 'u' && firstLetter <= 'v')
                {
                    time = 10;
                    date = SOPHOMORE_DATE_2;
                }
                else if (firstLetter >= 'w' && firstLetter <= 'z')
                {
                    time = 12;
                    date = SOPHOMORE_DATE_2;
                }
                else if (firstLetter >= 'a' && firstLetter <= 'b')
                {
                    time = 2;
                    date = SOPHOMORE_DATE_2;
                }
                else 
                {
                    time = 8;
                    date = SOPHOMORE_DATE_2;
                }

            else//If the higher conditions are not met then the user is seen as a freshman
                if (firstLetter >= 'e' && firstLetter <= 'f')
                {
                    time = 8;
                    date = FRESHMAN_DATE_1;
                }
                else if (firstLetter >= 'g' && firstLetter <= 'i')
                {
                    time = 10;
                    date = FRESHMAN_DATE_1;
                }
                else if (firstLetter >= 'j' && firstLetter <= 'l')
                {
                    time = 12;
                    date = FRESHMAN_DATE_1;
                }
                else if (firstLetter >= 'm' && firstLetter <= 'o')
                {
                    time = 2;
                    date = FRESHMAN_DATE_1;
                }

                else if (firstLetter >= 'p' && firstLetter <= 'r')
                {
                    time = 4;
                    date = FRESHMAN_DATE_1;
                }
                else if (firstLetter >= 's' && firstLetter <= 't')
                {
                    time = 8;
                    date = FRESHMAN_DATE_2;
                }
                else if (firstLetter >= 'u' && firstLetter <= 'v')
                {
                    time = 10;
                    date = FRESHMAN_DATE_2;
                }
                else if (firstLetter >= 'w' && firstLetter <= 'z')
                {
                    time = 12;
                    date = FRESHMAN_DATE_2;
                }
                else if (firstLetter >= 'a' && firstLetter <= 'b')
                {
                    time = 2;
                    date = FRESHMAN_DATE_2;
                }
                else
                {
                    time = 8;
                    date = FRESHMAN_DATE_2;
                }

            //creates the message box string, and then displays it in a message box
            messageBox = string.Format("Your first day of eligibility for class reigistration is on {0} at {1}:00", date, time);
            MessageBox.Show(messageBox, "Registration Date and Time");





        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clears the credit hour and last name text boxes, and focus on the credit hour text box
            creditHourTxt.Clear();
            lastNameTxt.Clear();
            creditHourTxt.Focus();
        }
    }
}