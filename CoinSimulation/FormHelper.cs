using System;
using System.Windows.Forms;

namespace CoinSimulation
{
    public static class FormHelper
    {
        public static bool IsNumberValue(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int i) || double.TryParse(textBox.Text, out double d);
        }

        public static bool CheckValidNumberInput(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (IsNumberValue(textBox))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
