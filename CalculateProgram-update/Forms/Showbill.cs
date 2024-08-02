using System;
using System.Windows.Forms;

namespace CalculateProgram
{
    public partial class Showbill : Form
    {
        // Constructor that accepts billing details
        public Showbill(string id, string name, string lastMonth, string thisMonth, string consumption, string price, string totalBill)
        {
            InitializeComponent();

            // Set the values of the labels
            IdValueBillLbl.Text = id;
            NameVlBill.Text = name;
            LMonthVLBill.Text = lastMonth;
            TMonthVlBill.Text = thisMonth;
            ConsVlBill.Text = consumption;
            PriceVlBill.Text = price;
            TotalVLBill.Text = totalBill;
        }

        private void Showbill_Load(object sender, EventArgs e)
        {

        }

        private void PayBillBttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error! System Updating.");
        }

    }
}
