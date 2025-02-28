/**
 * Angel Badillo
 * CMPS 4132
 * Program 8: Inventory Program
 * A simple MDI Windows Form application that allows you to "open" and edit
 * files containing "Record" data and saving files. Utilizes child forms
 * for displaying toy / hardware goods, and a UserControl "ItemForm"
 * that contains items details.
 */
using ItemForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program8MDI
{
    /// <summary>
    /// Simple form to be used to assist with
    /// entering data into a StoreForm.
    /// </summary>
    public partial class InputDataForm : Form
    {
        // Stores record data from textboxes when Ok button is pressed.
        public string RecordData { get; set; }

        /// <summary>
        /// Constructs InputDataForm.
        /// </summary>
        public InputDataForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Okay button. Returns DialogResult.OK
        /// when displayed with ShowDialog. Retrieves data from
        /// textboxes and stores to RecordData.
        /// </summary>
        /// <param name="sender">
        /// Component triggering event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void okButton_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes and store into formatted
            // string
            RecordData = $"{inputItemForm.ItemID}\t" +
                $"{inputItemForm.ItemName}\t{inputItemForm.ItemPrice}" +
                $"\t{inputItemForm.ItemQuantity}"; 
        }

        /// <summary>
        /// Event handler for cancel button. Returns DialogResult.Cancel.
        /// Closes the InputDataForm.
        /// </summary>
        /// <param name="sender">
        /// Component triggering event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
