using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlingAndValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateAgeButton_Click(object sender, EventArgs e)
        {
            //Have to convert to byte in order to assign variable
            //Having .Text is for getting the actual text from the Text
            try
            {
                byte age = Convert.ToByte(AgeTextBox.Text);
                
                if(age > 130 || age < 13)
                    throw new OverflowException();
                MessageBox.Show("Thanks for the age!");
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Your age must be a number!");
            }
            catch(OverflowException overflowException)
            {
                MessageBox.Show("Age must be between 13 and 130!");
            }
            finally
            {
                //Finally block ALWAYS Executes whether an Excpetion is triggered or not
                //ALWAYS!!!
                //Common uses
                //Close databas connecitons
                //Close file connections
            }

            //catch(Exception someEx)
            //{
            //    MessageBox.Show("Enter a valid Number!");
            //    MessageBox.Show(someEx.Message);
            //    MessageBox.Show(someEx.StackTrace);
            //    MessageBox.Show(someEx.GetType().ToString());
            //}
            MessageBox.Show("Test");
        }
    }
}
