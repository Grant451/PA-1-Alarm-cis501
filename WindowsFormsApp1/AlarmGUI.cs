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
        //the socond form
        private InputTime UserClockEditor;

        //list of all the clocks. 
        private static List<Alarm> clocks = new List<Alarm>();

        public Alarm501()
        {
            InitializeComponent();
        }

        /// <summary>
        /// edits an existing alarm, by pulling it out of the cloks list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int hold = Display.SelectedIndex;
            //MessageBox.Show(hold.ToString());
            int ClocksSize = clocks.Count();
            if ((hold < ClocksSize) && hold > -1)
            {
                UserClockEditor = new InputTime(this,false,hold);
                UserClockEditor.Show();
                clocks.Remove(clocks[hold]);
            }
        }

        /// <summary>
        /// add a clock to the form using the clock class. 
        /// if there are ten clocks in the system already it will notify the user. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UserClockEditor = new InputTime(this,true,0);
            UserClockEditor.Show();
            if (clocks.Count >= 10)
            {
                BtnAdd.Enabled = false;
            }
        }

        /// <summary>
        /// adds a clock 
        /// </summary>
        /// <param name="TimeObj">the data for the clock as a datetime</param>
        /// <param name="first">if it is a new clock or not</param>
        public static void AddClock(DateTime TimeObj,bool Io, bool first,int i)
        {
            Alarm temp = new Alarm();
            temp.Time = TimeObj;
            temp.On = Io;
            if (first)
            {
                clocks.Add(temp);
            }
            else
            {
                //insert the modified clock at the index. 
                clocks.Insert(i,temp);
            }
        }

        /// <summary>
        /// puts the clocks into the display box. 
        /// </summary>
        public void Redisplay()
        {
            Display.Items.Clear();
            foreach(Alarm x in clocks)
            {
                Display.Items.Add(x.ToString());
            }
            Display.Show();
        }

        /// <summary>
        /// adds thirty seconds to the selected clock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSnoose_Click(object sender, EventArgs e)
        {
            //pull out the current selected clock and add 30 seconds to it. 
            int hold = Display.SelectedIndex;
            int ClocksSize = clocks.Count();
            if((hold<ClocksSize)&&hold>-1)
            {//aparently this is the only way 30 sec can be added???
                Alarm temp = clocks[hold];
                temp.Time = temp.Time.AddSeconds(30);
                clocks[hold].Time = temp.Time;
                Redisplay();
            }
        }

        
        
        
    }
}
