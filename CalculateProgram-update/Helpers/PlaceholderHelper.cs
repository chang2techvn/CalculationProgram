using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculateProgram.Helpers
{
    public static class PlaceholderHelper
    {
        public static void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Silver;
            }
        }

        public static void SetComboBoxPlaceholder(ComboBox comboBox, string placeholder)
        {
            if (comboBox != null && comboBox.SelectedIndex == -1)
            {
                comboBox.Text = placeholder;
                comboBox.ForeColor = Color.Silver;
            }
        }

        public static void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == Color.Silver)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        public static void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrEmpty(textBox.Text))
            {
                SetPlaceholder(textBox, GetPlaceholderText(textBox));
            }
        }

        public static void ComboBox_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.ForeColor == Color.Silver)
            {
                comboBox.Text = "";
                comboBox.ForeColor = Color.Black;
            }
        }

        public static void ComboBox_Leave(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedIndex == -1)
            {
                SetComboBoxPlaceholder(comboBox, "Household customer, Administrative agency, public services, ");
            }
        }

        private static string GetPlaceholderText(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "IdCusTxtb":
                    return "PE12345678901,...";
                case "LMonthTxtb":
                    return "10, 20, 30, 40, 50,...";
                case "ThisMonthtxtb":
                    return "10, 20, 30, 40, 50,...";
                case "NameCusTxtb":
                    return "Charles Darwin,...";
                case "numberPeoplerTxtb":
                    return "0, 1, 2, 3,...(If Household Customer)";
                case "SearchTxtbox":
                    return "Pe12345, John, 10 m3,...";
                default:
                    return string.Empty;
            }
        }
    }
}
