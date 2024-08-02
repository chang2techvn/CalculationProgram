using System;
using System.Drawing;
using System.Windows.Forms;
using CalculateProgram.Modules;
using CalculateProgram.Helpers;

namespace CalculateProgram
{
    public partial class Main : Form
    {
        // Constructor to initialize the form and context menu
        public Main()
        {
            InitializeComponent();
            CreateHeadCol();
            AssignEvents();
            SetPlaceholders();
            AddContextMenuStrips();
        }

        private void AddContextMenuStrips()
        {
            // Add sorting options to the context menu
            contextMenuStrip1.Items.Add("Name (A-Z)");
            contextMenuStrip1.Items.Add("Consumption (Low to High)");
            contextMenuStrip1.Items.Add("Consumption (High to Low)");
            contextMenuStrip1.Items.Add("Total Bill (Low to High)");
            contextMenuStrip1.Items.Add("Total Bill (High to Low)");
        }

        // Create columns for the ListView
        private void CreateHeadCol()
        {
            lvResult.View = View.Details;
            lvResult.Columns.Add("No.", 50);
            lvResult.Columns.Add("ID", 50);
            lvResult.Columns.Add("Name", 50);
            lvResult.Columns.Add("Last Month", 70);
            lvResult.Columns.Add("This Month", 70);
            lvResult.Columns.Add("Consumption", 80);
            lvResult.Columns.Add("Price", 70);
            lvResult.Columns.Add("Total Bill", 100);
 
        }
        // Calculate bill and display results in ListView and Showbill form
        private void CalculateBtt_Click(object sender, EventArgs e)
        {
            if (InputValidationHelper.ValidateInputs(IdCusTxtb, NameCusTxtb, LMonthTxtb, ThisMonthtxtb, TypeOfCustomerTxtb, numberPeoplerTxtb,
                out string id, out string name, out int lastMonth, out int thisMonth, out string customerType, out int numberOfPeople))
            {
                int consumption = thisMonth - lastMonth;
                var (price, totalBill) = CalculateBill(customerType, lastMonth, thisMonth, numberOfPeople, consumption);
                DisplayResult(id, name, lastMonth, thisMonth, consumption, price, totalBill);
            }
        }

        private (double price, double totalBill) CalculateBill(string customerType, int lastMonth, int thisMonth, int numberOfPeople, int consumption)
        {

            double price;
            double totalBill;

            // Calculate price and total bill based on customer type
            if (customerType == "Household customer")
            {
                (price, totalBill) = CalculationModule.CalculateBill(customerType, consumption, numberOfPeople);
            }
            else
            {
                (price, totalBill) = CalculationModule.CalculateBill(customerType, consumption, 1);
            }

            return (price, totalBill); // Added missing return statement
        }

        private void DisplayResult(string id, string name, int lastMonth, int thisMonth, int consumption, double price, double totalBill)
        {
            // Add results to ListView
            lvResult.Items.Clear();
            int index = lvResult.Items.Count + 1;
            ListViewItem item = new ListViewItem(index.ToString())
            {
                SubItems =
                {
                    new ListViewItem.ListViewSubItem(null, id),
                    new ListViewItem.ListViewSubItem(null, name),
                    new ListViewItem.ListViewSubItem(null, lastMonth.ToString() + " m3"),
                    new ListViewItem.ListViewSubItem(null, thisMonth.ToString() + " m3"),
                    new ListViewItem.ListViewSubItem(null, consumption.ToString() + " m3"),
                    new ListViewItem.ListViewSubItem(null, price.ToString("0.00") + " đ/m3"),
                    new ListViewItem.ListViewSubItem(null, totalBill.ToString("0.00") + " đ"),
                    new ListViewItem.ListViewSubItem(null, "Showbill"),
                    new ListViewItem.ListViewSubItem(null, "Delete")
                }
            };
            lvResult.Items.Add(item);

            // Resize columns
            for (int i = 0; i < lvResult.Columns.Count; i++)
            {
                lvResult.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                lvResult.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            // Save results to file
            string filePath = "Results.txt";
            FileModule.SaveResultsToFile(filePath, lvResult);

            // Show detailed billing information in a separate form
            Showbill showbillForm = new Showbill(
                id,
                name,
                lastMonth.ToString() + " m3",
                thisMonth.ToString() + " m3",
                consumption.ToString() + " m3",
                price.ToString("0.00") + " đ/m3",
                totalBill.ToString("0.00") + " đ"
            );
            showbillForm.ShowDialog();
        }




        // Search for results in ListView and file
        private void searchBtt_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxtbox.Text;
            string filePath = "Results.txt";

            SearchModule.SearchAndDisplayResults(lvResult, searchTerm, filePath);
        }

        // Event handler for context menu item clicks
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int columnIndex = -1;  // Initialize column index for sorting
            bool ascending = true; // Initialize sort order as ascending

            // Determine the column index and sort order based on the clicked menu item
            switch (e.ClickedItem.Text)
            {
                case "Name (A-Z)":
                    columnIndex = 2;   // Set column index 
                    ascending = true;  // Set sort order as ascending
                    break;
                case "Consumption (Low to High)":
                    columnIndex = 5;   
                    ascending = true;  
                    break;
                case "Consumption (High to Low)":
                    columnIndex = 5;  
                    ascending = false; 
                    break;
                case "Total Bill (Low to High)":
                    columnIndex = 7;   
                    ascending = true; 
                    break;
                case "Total Bill (High to Low)":
                    columnIndex = 7;   
                    ascending = false; 
                    break;
            }

            // If a valid column index is set, proceed with sorting
            if (columnIndex != -1)
            {
                // Call the sorting module to sort the ListView based on the selected column and order
                SortingModule.SortListView(lvResult, columnIndex, ascending);
            }
        }


        // Show context menu on PictureBox click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox1, new Point(0, pictureBox1.Height));
        }

        //Clear Button
        private void ClearBtt_Click(object sender, EventArgs e)
        {
            IdCusTxtb.Clear();
            LMonthTxtb.Clear();
            ThisMonthtxtb.Clear();
            NameCusTxtb.Clear();
            numberPeoplerTxtb.Clear();
            TypeOfCustomerTxtb.SelectedIndex = -1;

            SetPlaceholders();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SearchTxtbox.Clear();
        }

        // Set placeholder text for input fields
        private void AssignEvents()
        {
            IdCusTxtb.Enter += PlaceholderHelper.TextBox_Enter;
            IdCusTxtb.Leave += PlaceholderHelper.TextBox_Leave;
            NameCusTxtb.Enter += PlaceholderHelper.TextBox_Enter;
            NameCusTxtb.Leave += PlaceholderHelper.TextBox_Leave;
            LMonthTxtb.Enter += PlaceholderHelper.TextBox_Enter;
            LMonthTxtb.Leave += PlaceholderHelper.TextBox_Leave;
            ThisMonthtxtb.Enter += PlaceholderHelper.TextBox_Enter;
            ThisMonthtxtb.Leave += PlaceholderHelper.TextBox_Leave;
            numberPeoplerTxtb.Enter += PlaceholderHelper.TextBox_Enter;
            numberPeoplerTxtb.Leave += PlaceholderHelper.TextBox_Leave;
            TypeOfCustomerTxtb.Enter += PlaceholderHelper.ComboBox_Enter;
            TypeOfCustomerTxtb.Leave += PlaceholderHelper.ComboBox_Leave;
            SearchTxtbox.Enter += PlaceholderHelper.TextBox_Enter;
            SearchTxtbox.Leave += PlaceholderHelper.TextBox_Leave;

        }

        //Show bill in ListView
        private void lvResult_MouseClick(object sender, MouseEventArgs e)
        {
            // Determine the item that was clicked
            ListViewItem item = lvResult.HitTest(e.Location).Item;
            if (item != null)
            {
                // Get information from the selected item
                var id = item.SubItems[1].Text;
                var name = item.SubItems[2].Text;
                var lastMonth = item.SubItems[3].Text;
                var thisMonth = item.SubItems[4].Text;
                var consumption = item.SubItems[5].Text;
                var price = item.SubItems[6].Text;
                var totalBill = item.SubItems[7].Text;

                // Display the Showbill form with detailed information
                Showbill showbillForm = new Showbill(
                    id,
                    name,
                    lastMonth,
                    thisMonth,
                    consumption,
                    price,
                    totalBill
                );
                showbillForm.ShowDialog();
            }
        }

        private void SetPlaceholders()
        {
            PlaceholderHelper.SetPlaceholder(IdCusTxtb, "PE12345678901,...");
            PlaceholderHelper.SetPlaceholder(LMonthTxtb, "10, 20, 30, 40, 50,...");
            PlaceholderHelper.SetPlaceholder(ThisMonthtxtb, "10, 20, 30, 40, 50,...");
            PlaceholderHelper.SetPlaceholder(NameCusTxtb, "Charles Darwin,...");
            PlaceholderHelper.SetPlaceholder(numberPeoplerTxtb, "0, 1, 2, 3,...(If Household Customer)");
            PlaceholderHelper.SetComboBoxPlaceholder(TypeOfCustomerTxtb, "Household customer, Administrative agency, public services, ");
            PlaceholderHelper.SetPlaceholder(SearchTxtbox, "Pe12345, John, 10 m3,...");
        }

     
    }
}




