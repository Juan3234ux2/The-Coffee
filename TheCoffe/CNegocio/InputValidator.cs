using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.CNegocio
{
    public static class InputValidator
    {
        public enum InputType
        {
            Letters,
            Digits
        }

        public static void ValidateInput(KeyPressEventArgs e, InputType type)
        {
            switch (type)
            {
                case InputType.Letters:
                    if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                    break;

                case InputType.Digits:
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                    break;
            }
        }
    }

}
