using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SGV
{
    class Audio
    {
        String pathFile;

        public Audio(String pathFile)
        {
            this.pathFile = pathFile;
        }

        public string PathFile
        {
            get
            {
                return pathFile;
            }

            set
            {
                pathFile = value;
            }
        }
    }
}