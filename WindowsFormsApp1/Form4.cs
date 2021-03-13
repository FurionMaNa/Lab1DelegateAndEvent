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
    public partial class Form4 : Form1
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            eventClass.events += new EventClass.EventButtonClickHandler(ClickButtonEventForm4);
        }

        private void ClickButtonEventForm4(object sender, ModifiedEventArgs modifiedEventArgs)
        {
            textBox1.Text = modifiedEventArgs.XLeftUp.ToString();
            textBox2.Text = modifiedEventArgs.YLeftUp.ToString();
            textBox3.Text = modifiedEventArgs.XRightDown.ToString();
            textBox4.Text = modifiedEventArgs.YRightDown.ToString();
        }
    }
}
