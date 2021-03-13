using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Form3 : Form1
    {

        private static Panel panel = null;

        public Form3()
        {
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            Width = 600;
            Text = "Main Form";
            eventClass.events += new EventClass.EventButtonClickHandler(ClickButtonEventForm3);
            panel = new Panel();
            panel.Location = new System.Drawing.Point(12, 12);
            panel.Width = 560;
            panel.Height = 337;
            panel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(panel);
        }

        private static void ClickButtonEventForm3(object sender, ModifiedEventArgs modifiedEventArgs)
        {
            Graphics g = panel.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.LightGray);
            g.FillRectangle(brush, 0, 0, 590, 337);
            brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush,
                modifiedEventArgs.XLeftUp,
                modifiedEventArgs.YLeftUp,
                modifiedEventArgs.XRightDown - modifiedEventArgs.XLeftUp,
                modifiedEventArgs.YRightDown - modifiedEventArgs.YLeftUp);
        }
    }
}
