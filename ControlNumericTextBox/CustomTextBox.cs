using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlNumericTextBox
{
    public class CustomTextBox:TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar=='-')
            {
                ;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
