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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemForm
{
    /// <summary>
    /// A simple UserControl with labels and textboxes 
    /// for use of entering Records.
    /// </summary>
    public partial class ItemForm : UserControl
    {
        /// <summary>
        /// Constructs an ItemForm UserControl
        /// </summary>
        public ItemForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Return item ID from textbox.
        /// </summary>
        public string ItemID => itemIDTextBox.Text;

        /// <summary>
        /// Return item name from textbox.
        /// </summary>
        public string ItemName => itemNameTextBox.Text;

        /// <summary>
        /// Return item price from textbox.
        /// </summary>
        public string ItemPrice => itemPriceTextBox.Text;

        /// <summary>
        /// Returns item quantity from textbox.
        /// </summary>
        public string ItemQuantity => itemQuantityTextBox.Text;
        
    }
}
