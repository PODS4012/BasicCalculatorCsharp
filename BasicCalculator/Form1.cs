using System;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnCE_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text box
            FocusInputText();
        }

        /// <summary>
        /// Deletes the first character in front of the cursor
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            DeleteTextValue();

            // Focus the user input text box
            FocusInputText();
        }

        #endregion

        #region Operators Methods

        private void btnDevide_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            // Focus the user input text box
            FocusInputText();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            // Focus the user input text box
            FocusInputText();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            // Focus the user input text box
            FocusInputText();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            // Focus the user input text box
            FocusInputText();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            // Focus the user input text box
            FocusInputText();
        }

        

        #endregion

        #region Number Methods

        private void btn0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            // Focus the user input text box
            FocusInputText();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            // Focus the user input text box
            FocusInputText();
        }

        private void btnDot(object sender, EventArgs e)
        {
            InsertTextValue(",");

            // Focus the user input text box
            FocusInputText();
        }

        #endregion

        /// <summary>
        /// Calculate the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {

            // TODO: finnish

            // Focus the user input text box
            FocusInputText();
        }

        #region Private Helpers

        /// <summary>
        /// Focuses the user input box
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStrart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStrart + value.Length;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Delete the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If we don't have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            // Remember selection start
            var selectionStrart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);


            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStrart;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }



        #endregion

    }
}
