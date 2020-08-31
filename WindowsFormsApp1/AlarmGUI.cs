/*Grant Clothier
 * Alarmclock pa-1 
 * 8/30/2020
 * The program manages up to ten alarms with the ability to edit them. 
 * It also saves them to a file when finished. 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells.Drawing;

namespace WindowsFormsApp1
{
    public partial class Alarm501 : Form
    {
        private InputTime UserClockEditor;

        //list of all the clocks. 
        private static List<Alarm> clocks = new List<Alarm>();

        public Alarm501()
        {
            InitializeComponent();
            //Alarm501.IsMdiContainer = true;
             
        }

        /// <summary>
        /// edits an existing alarm, by pulling it out of the cloks list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        /// <summary>
        /// add a clock to the form using the clock class. 
        /// if there are ten clocks in the system already it will notify the user. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UserClockEditor = new InputTime();
            UserClockEditor.Show();
            if (clocks.Count >= 10)
            {
                //this.BtnAdd.Enabled = true;
                BtnAdd.Enabled = false;
            }
        }

        /// <summary>
        /// takes int the datetime to add the new clock from the second form. 
        /// </summary>
        public static void AddClock(DateTime TimeObj)
        {
            Alarm temp = new Alarm();
            temp.Time = TimeObj;//UserTime;//new DateTimePicker();
            clocks.Add(temp);
        }
    }
}
