using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class EventClass
    {
        public delegate void EventButtonClickHandler(Object source, ModifiedEventArgs e);
        public event EventButtonClickHandler events;

        public void ClickEvent(Object sender, ModifiedEventArgs modifiedEventArgs)
        {
            if (this.events != null)
            {
                events.Invoke(sender, modifiedEventArgs);
            }
            else
            {
                MessageBox.Show("Вы не открыли окна для рисования", "Ошибка",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
