using System.Windows.Forms;

namespace CalculateProgram.Modules
{
    public static class SortingModule
    {
        public static void SortListView(ListView lvResult, int columnIndex, bool ascending)
        {
            if (columnIndex != -1)
            {
                lvResult.ListViewItemSorter = new ListViewItemComparer(columnIndex, ascending);
                lvResult.Sort();


                for (int i = 0; i < lvResult.Items.Count; i++)
                {
                    lvResult.Items[i].Text = (i + 1).ToString();
                }


                // Resize columns to fit content
                for (int i = 0; i < lvResult.Columns.Count; i++)
                {
                    lvResult.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvResult.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
    }

}
