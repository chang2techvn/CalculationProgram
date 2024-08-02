using System.IO;
using System.Windows.Forms;

namespace CalculateProgram.Modules
{
    public static class FileModule
    {
        public static void SaveResultsToFile(string filePath, ListView lvResult)
        {

            bool fileExists = File.Exists(filePath);

            using (StreamWriter sw = new StreamWriter(filePath, append: true))
            {
                if (!fileExists)
                {
                    foreach (ColumnHeader column in lvResult.Columns)
                    {
                        sw.Write(column.Text + "\t");
                    }
                    sw.WriteLine();
                }

                foreach (ListViewItem item in lvResult.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        sw.Write(item.SubItems[i].Text + "\t");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
