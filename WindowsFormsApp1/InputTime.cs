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
        public InputTime()
        {
            InitializeComponent();
            //DTPInput.CustomFormat = "MM DD YYYY hh mm ss";
            //InputTime.ActiveForm = false;
            DTPInput.Format = DateTimePickerFormat.Custom;
            DTPInput.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        public void DisplayTimePicker()
        {
            //MessageBox.Show("here");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            Alarm501.AddClock(DTPInput.Value);
        }
    }
}
