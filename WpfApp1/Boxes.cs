using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class TextBoxFocusElements
    {
        public TextBox TBox = null!;
        public string NotFocusValue { get; set; } = null!;
        public Brush InputColor { get; set; } = null!;
        public Brush NotFocusColor { get; set; } = null!;
        public TextBoxFocusElements(TextBox TBox, Brush InputColor, Brush NotFocusColor, string NotFocusValue = "")
        {
            this.TBox = TBox;
            this.InputColor = InputColor;
            this.NotFocusColor = NotFocusColor;
            this.NotFocusValue = NotFocusValue;
        }
    }
    class TBoxesFocusCheck
    {
        private TextBoxFocusElements FocusElements;
        public TBoxesFocusCheck(TextBox TBox, Brush InputColor, Brush NotFocusColor, string NotFocusValue = "")
        {
            FocusElements = new TextBoxFocusElements(TBox, InputColor, NotFocusColor, NotFocusValue);
        }
    
        public void TBox_GotFocus()
        {
            
            if (FocusElements.TBox.Text == FocusElements.NotFocusValue)
            {
                FocusElements.TBox.Text = "";
                FocusElements.TBox.Foreground = FocusElements.InputColor;
            }
        }

        public void TBox_LostFocus()
        {
            if (string.IsNullOrEmpty(FocusElements.TBox.Text))
            {
                FocusElements.TBox.Text = FocusElements.NotFocusValue;
                FocusElements.TBox.Foreground = FocusElements.NotFocusColor;
            }

        }
        
    }
    class PBoxFocusElements
    {
        public PasswordBox PBox = null!;
        public Label NotFocusValue { get; set; } = null!;
        public Brush InputColor { get; set; } = null!;
        public Brush NotFocusColor { get; set; } = null!;
        public PBoxFocusElements(PasswordBox PBox, Brush InputColor, Brush NotFocusColor, Label NotFocusValue)
        {
            this.PBox = PBox;
            this.InputColor = InputColor;
            this.NotFocusColor = NotFocusColor;
            this.NotFocusValue = NotFocusValue;
        }
    }
    class PBoxesFocusCheck
    {
        private PBoxFocusElements FocusElements;
        public PBoxesFocusCheck(PasswordBox PBox, Brush InputColor, Brush NotFocusColor, Label NotFocusLabel)
        {
            FocusElements = new PBoxFocusElements(PBox, InputColor, NotFocusColor, NotFocusLabel);
        }
        public void PBox_GotFocus()
        {
            if (FocusElements.PBox == null)
            {
                return;
            }
            FocusElements.NotFocusValue.Visibility = Visibility.Hidden;
            FocusElements.PBox.Foreground = FocusElements.InputColor;
        }
        public void PBox_LostFocus()
        {
            if (string.IsNullOrEmpty(FocusElements.PBox.Password))
            {
                FocusElements.NotFocusValue.Visibility = Visibility.Visible;
                FocusElements.PBox.Foreground = FocusElements.NotFocusColor;
            }
        }
    }
}
