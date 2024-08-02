using System;
using System.Collections;
using System.Windows.Forms;

namespace CalculateProgram
{
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private bool ascending;

        public ListViewItemComparer(int column, bool ascending = true)
        {
            col = column;
            this.ascending = ascending;
        }

        public int Compare(object x, object y)
        {
            string textX = ((ListViewItem)x).SubItems[col].Text;
            string textY = ((ListViewItem)y).SubItems[col].Text;

            // Try to parse numeric values from the strings
            double valX, valY;
            bool isNumericX = double.TryParse(ExtractNumericPart(textX), out valX);
            bool isNumericY = double.TryParse(ExtractNumericPart(textY), out valY);

            if (isNumericX && isNumericY)
            {
                return ascending ? valX.CompareTo(valY) : valY.CompareTo(valX);
            }
            else
            {
                return ascending ? string.Compare(textX, textY) : string.Compare(textY, textX);
            }
        }

        // Extracts the numeric part from a string
        private string ExtractNumericPart(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
