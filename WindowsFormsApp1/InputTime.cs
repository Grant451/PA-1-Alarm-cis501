//Grant Clothier
//this methode will take in perameters about the type of clock it is creating then 
//it will tell the Alarm501 partial class to create the clock. 
//note it displays the current time by default every time it is called.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputTime : Form
    {
        //holds an instance of alarm501
        //this allows the redisplay function to be called. 
        private Alarm501 x;

        //if this is a new clock or not. 
        private bool first;

        //the position to add the clock to in the clocks list
        private int pos;

        /// <summary>
        /// constructor takes an instance of Alarm501
        /// this allows the redisplay funciton to be called. 
        /// </summary>
        /// <param name="x">takes in an instance of Alarm 501</param>
        public InputTime(Alarm501 X, bool First,int Pos)
        {
            this.x = X;
            first = First;
            pos = Pos;
            InitializeComponent();
            DTPInput.Format = DateTimePickerFormat.Custom;
            DTPInput.ShowUpDown = true;
            DTPInput.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        public void DisplayTimePicker()
        {

        }

        /// <summary>
        /// when clicked it closes iself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// when clicked it sends the time to the other form and closes itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSet_Click(object sender, EventArgs e)
        {
            Alarm501.AddClock(DTPInput.Value,RbnOn.Checked,first,pos);
            var thing = new Alarm501();
            x.Redisplay();
            this.Close();
        }

        private void RbnOn_Click(object sender, EventArgs e)
        {
            RbnOn.Checked = !RbnOn.Checked;
            if(RbnOn.Checked)
            {
                RbnOn.Text = "On";
            }
            else
            {
                RbnOn.Text = "Off";
            }
        }
    }
}
