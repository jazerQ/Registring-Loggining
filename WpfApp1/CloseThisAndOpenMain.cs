using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class CloseThisAndOpenMain
    {
        private Window window { get; set; }
        public CloseThisAndOpenMain(Window window)
        {
            this.window = window;
        }
        public void Close() 
        {
            if(window != null)
            {
                new Launcher().Show();
                window.Close();
            }
        }
    }
}
