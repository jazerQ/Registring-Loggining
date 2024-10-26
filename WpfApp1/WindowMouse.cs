using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    static class WindowMouse
    {
        public static void Down(PBoxesFocusCheck pBox1, params TBoxesFocusCheck[] tBoxes)
        {
            Keyboard.ClearFocus();
            pBox1.PBox_LostFocus();
            foreach (var t in tBoxes)
            {
                t.TBox_LostFocus();
            }
        }
        
    }
}
