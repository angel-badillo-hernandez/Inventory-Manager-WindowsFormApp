/**
 * Angel Badillo
 * CMPS 4132
 * Program 8: Inventory Program
 * A simple MDI Windows Form application that allows you to "open" and edit
 * files containing "Record" data and saving files. Utilizes child forms
 * for displaying toy / hardware goods, and a UserControl "ItemForm"
 * that contains items details.
 */
using System;
using System.IO;
using System.Windows.Forms;

namespace Program8MDI
{
    /// <summary>
    /// InventoryFormMDI that is used as an MDI Container for displaying
    /// StoreForms that displays inventory of the store in a listbox.
    /// </summary>
    public partial class InventoryFormMDI : Form
    {
        /// <summary>
        /// Constructs InventoryMDI.
        /// </summary>
        public InventoryFormMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for File->Open button
        /// </summary>
        /// <param name="sender">
        /// Component that triggered event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            // Display OpenFileDialog
            using (var fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            // Create file if ok was clicked
            if (result == DialogResult.OK)
            {
                // Return if empty string
                if (string.IsNullOrEmpty(fileName))
                    return;

                // Display child form (StoreForm)
                var childForm = new StoreForm(fileName);
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        /// <summary>
        /// Event handler for exit button. Closes the exit button.
        /// </summary>
        /// <param name="sender">
        /// Component that triggers the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the save button. Saves the data from the listbox
        /// in the child form to the corresponding serialized file.
        /// </summary>
        /// <param name="sender">
        /// Component that triggers the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is StoreForm form)
            {
                form.SaveData();
            }
        }

        /// <summary>
        /// Event handler for inserting item 
        /// </summary>
        /// <param name="sender">
        /// Component that triggers the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only display InputDataForm if ActiveMdiChild is StoreForm.
            if (ActiveMdiChild is StoreForm form)
            {
                // Prompt user for input
                InputDataForm inputForm = new InputDataForm();
                DialogResult result = inputForm.ShowDialog();
                string temp = "";

                // If result is okay, store input into listBox.
                if (result == DialogResult.OK)
                {
                    temp += inputForm.RecordData;
                    form.AddItem(temp);
                }
            }
        }

        /// <summary>
        /// Delete an item from the active index in the active child form.
        /// Does nothing
        /// </summary>
        /// <param name="sender">
        /// Component that triggers the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only remove if ActiveMDIChild is a StoreForm
            if (ActiveMdiChild is StoreForm form)
            {
                // Prompt user for confirmation
                DialogResult result = MessageBox.Show("Are you sure " +
                    "you want to remove this item?", "Remove item?",
                    MessageBoxButtons.OKCancel);

                // Remove item if result is OK
                if (result == DialogResult.OK)
                {
                    form.RemoveItem();
                }
            }
        }

        /// <summary>
        /// Create a new file by opening displaying SaveFileDialog,
        /// creating new empty file, then showing StoreForm.
        /// </summary>
        /// <param name="sender">
        /// Component that triggers event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            // Prompt user for file name and create file
            using (var fileChooser = new SaveFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;

                // If OK button button was pressed
                if (result == DialogResult.OK)
                {
                    FileStream temp = File.Create(fileName);
                    temp.Close();
                    var childForm = new StoreForm(fileName);
                    childForm.MdiParent = this;
                    childForm.Show();
                }
            }
        }
    }
}
