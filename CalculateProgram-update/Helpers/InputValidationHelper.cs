using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculateProgram.Helpers
{
    public static class InputValidationHelper
    {
        public static bool ValidateInputs(
            TextBox idTextBox,
            TextBox nameTextBox,
            TextBox lastMonthTextBox,
            TextBox thisMonthTextBox,
            ComboBox customerTypeComboBox,
            TextBox numberOfPeopleTextBox,
            out string id,
            out string name,
            out int lastMonth,
            out int thisMonth,
            out string customerType,
            out int numberOfPeople)
        {
            // Initialize output parameters
            id = idTextBox.Text;
            name = nameTextBox.Text;
            customerType = customerTypeComboBox.Text;
            numberOfPeople = 0;
            lastMonth = 0;
            thisMonth = 0;


            // Placeholder values
            string idPlaceholder = "PE12345678901,...";
            string namePlaceholder = "Charles Darwin,...";
            string lastMonthPlaceholder = "10, 20, 30, 40, 50,...";
            string thisMonthPlaceholder = "10, 20, 30, 40, 50,...";
            string customerTypePlaceholder = "Household customer, Administrative agency, public services, ";
            string numberOfPeoplePlaceholder = "0, 1, 2, 3,...(If Household Customer)";

            // Check if all fields are placeholders
            if (id == idPlaceholder &&
                name == namePlaceholder &&
                lastMonthTextBox.Text == lastMonthPlaceholder &&
                thisMonthTextBox.Text == thisMonthPlaceholder &&
                customerType == customerTypePlaceholder &&
                numberOfPeopleTextBox.Text == numberOfPeoplePlaceholder)
            {
                MessageBox.Show("Please enter your information in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if ID is not entered
            if (id == "PE12345678901,...")
            {
                MessageBox.Show("Please enter your ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if Name is a placeholder or contains invalid characters
            string namePattern = @"^[a-zA-Z\s]+$"; // Only letters and spaces
            if (string.IsNullOrWhiteSpace(name) ||
                name == "Charles Darwin,..." ||
                !Regex.IsMatch(name, namePattern))
            {
                MessageBox.Show("Please enter a valid name! The name should not contain numbers or special characters, and should not be the placeholder name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate water consumption inputs
            bool isLastMonthValid = int.TryParse(lastMonthTextBox.Text, out lastMonth);
            bool isThisMonthValid = int.TryParse(thisMonthTextBox.Text, out thisMonth);

            if (isLastMonthValid && isThisMonthValid)
            {
                // Check if current month's water consumption is greater than last month's
                if (thisMonth <= lastMonth)
                {
                    MessageBox.Show("The current month's water consumption must be greater than the last month's.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Handle invalid input cases
                if (string.IsNullOrWhiteSpace(lastMonthTextBox.Text))
                {
                    MessageBox.Show("The last month field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(thisMonthTextBox.Text))
                {
                    MessageBox.Show("The current month field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!isLastMonthValid)
                {
                    MessageBox.Show("Invalid input for the last month. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!isThisMonthValid)
                {
                    MessageBox.Show("Invalid input for the current month. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }

            // Check if customer type is selected
            if (customerType == "Household customer, Administrative agency, public services, ")
            {
                MessageBox.Show("Please choose a type of customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate number of people if the customer is a household customer
            if (customerType == "Household customer" && !int.TryParse(numberOfPeopleTextBox.Text, out numberOfPeople))
            {
                MessageBox.Show("Please enter a valid number for the number of People", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // All validations passed
            return true;
        }
    }
}
