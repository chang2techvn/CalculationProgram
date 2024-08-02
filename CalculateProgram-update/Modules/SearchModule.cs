using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CalculateProgram.Modules
{
    public static class SearchModule
    {
        // Searches for results in ListView and file, then displays them
        public static void SearchAndDisplayResults(ListView lvResult, string searchTerm, string filePath)
        {
            // Clear existing items in the ListView
            lvResult.Items.Clear();
            List<ListViewItem> results = new List<ListViewItem>();

            // Search in ListView items
            foreach (ListViewItem item in lvResult.Items)
            {
                if (item.SubItems[1].Text.Contains(searchTerm))
                {
                    results.Add((ListViewItem)item.Clone()); // Clone matching items
                }
            }

            // Search in the file
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line.Contains(searchTerm) && !line.Contains("Name"))
                {
                    // Split line into columns and create a new ListViewItem
                    string[] columns = line.Split('\t');
                    ListViewItem newItem = new ListViewItem(columns[0]);
                    for (int i = 1; i < columns.Length; i++)
                    {
                        newItem.SubItems.Add(columns[i]);
                    }
                    results.Add(newItem); // Add new items to results
                }
            }

            // Sort results to prioritize exact matches
            results.Sort((x, y) =>
            {
                bool xExactMatch = x.SubItems[1].Text == searchTerm;
                bool yExactMatch = y.SubItems[1].Text == searchTerm;

                if (xExactMatch && !yExactMatch) return -1;
                if (!xExactMatch && yExactMatch) return 1;

                return 0;
            });

            // Add sorted results to ListView
            int index = 1;
            foreach (var item in results)
            {
                item.Text = index.ToString();
                lvResult.Items.Add(item);
                index++;
            }

            // Adjust column widths to fit content
            foreach (ColumnHeader column in lvResult.Columns)
            {
                column.Width = -2; // -2 adjusts column width to fit content
            }

            // Show message based on search results
            if (results.Count > 0)
            {
                MessageBox.Show("Found and displayed " + results.Count + " result(s).");
            }
            else
            {
                MessageBox.Show("Not Found! Please enter a different key.");
            }
        }
    }
}
