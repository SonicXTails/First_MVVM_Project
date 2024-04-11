using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Calculator.ViewModels.Helpers
{
    internal class TextBox_OnlyNumbers
    {
        public static void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!Regex.IsMatch(textBox.Text, "^[0-9]*$"))
            {
                textBox.Text = string.Empty;
            }
        }
    }
}
