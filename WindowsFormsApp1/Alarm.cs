//Grant Clothier
//This is the Alarm class, It holds the status of the alarm as well as the time. 
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	class Alarm
	{
		/// <summary>
		/// overrides the default ToString methode so that the on/off status can be displayed. 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if(on)
			{
				return time.ToString() + " On";
			}
			else
			{
				return time.ToString() + " Off";
			}
		}

		//used to store the time object
		private DateTime time = new DateTime();

		/// <summary>
		/// sets time
		/// </summary>
		public DateTime Time
		{
			get { return time; }
			set => time = value;
		}

		//private variable to store the alarms status. 
		private bool on;

		/// <summary>
		/// keeps track of the alarms status. 
		/// </summary>
		public bool On
		{
			get { return on; }
			set
			{
				on = value;
			}
		}

		

	}

}
