using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace VitalPixels.Config
{
    class DisplayNameCustomAttribute : DisplayNameAttribute
    {


        public override string DisplayName
        {
            get
            {
                return ImageProperty.GetCustomName();
            }
        }
    }
}
