﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EnlightKinectFountainApp
{
    public class RightHandEventArgs : RoutedEventArgs
    {
        public RightHandEventArgs(Point rightHand)
        {
            this.RightHandPoint = rightHand;
        }

        public Point RightHandPoint
        {
            get;
            private set;
        }
    }
}
