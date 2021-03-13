using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class ModifiedEventArgs : EventArgs
    {

        private int xLeftUp;
        private int yLeftUp;

        private int xRightDown;
        private int yRightDown;

        public ModifiedEventArgs(int xLeftUp, int yLeftUp, int xRightDown, int yRightDown)
        {
            this.XLeftUp = xLeftUp;
            this.YLeftUp = yLeftUp;
            this.XRightDown = xRightDown;
            this.YRightDown = yRightDown;
        }

        public int XLeftUp { get => xLeftUp; set => xLeftUp = value; }
        public int YLeftUp { get => yLeftUp; set => yLeftUp = value; }
        public int XRightDown { get => xRightDown; set => xRightDown = value; }
        public int YRightDown { get => yRightDown; set => yRightDown = value; }
    }
}