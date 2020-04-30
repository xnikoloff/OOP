using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    class Display
    {
        private double screenSize;
        private int colors;

        public Display()
            : this(default(Double), default(Int32))
        {

        }

        public Display(double screenSize)
            : this(screenSize, default(Int32))
        {

        }

        public Display(double screenSize, int colors)
        {
            this.screenSize = screenSize;
            this.colors = colors;
        }

        public double ScreenSize
        {
            get { return this.screenSize; }
            set { this.screenSize = value; }
        }

        public int Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }
    }
}
