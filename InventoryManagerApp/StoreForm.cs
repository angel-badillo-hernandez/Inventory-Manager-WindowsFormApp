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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program8MDI
{
    /// <summary>
    /// Simple form for viewing Store inventory and selecting items.
    /// To be used in InventoryFormMDI as a child form.
    /// </summary>
    public partial class StoreForm : Form
    {
        // Stores the filepath
        public string FileName { get; set; }

        /// <summary>
        /// Create StoreForm and set filepath using
        /// the passed in argument fileName.
        /// </summary>
        /// <param name="fileName"> Name of serialized file. </param>
        public StoreForm(string fileName): this() 
        {
            FileName = fileName;

            // Used for formatting filepath to receive file name
            FileInfo temp = new FileInfo(FileName);

            // Rename form to file name
            Text = "Store: " + temp.Name.Replace(temp.Extension, "");

            // Open file for read
            FileStream infile = new FileStream(FileName, FileMode.Open, 
                FileAccess.Read);
            BinaryFormatter reader = new BinaryFormatter();

            // Add column headings
            itemListBox.Items.Add($"ID\tName\tPrice\tQuantity");

            // Highlight entire row when selecting
            itemListBox.ColumnWidth = itemListBox.Width;

            // Read entire file until serialization exeception occurs
            while (true)
            {
                // Attempt to deserialize data from file and add to listbox
                try
                {
                    Record record = (Record)reader.Deserialize(infile);
                    itemListBox.Items.Add($"{record.ID}\t{record.Name}" +
                        $"\t{record.Price}\t{record.Quantity}");
                }
                // Once exeception occurs we update itemCountLabel
                catch(SerializationException)
                {
                    // Update itemCountLabel to display no. of items.
                    itemCountLabel.Text = $"There are {itemListBox.Items.Count-1} " +
                        $"items in this file.";

                    // Close file
                    infile.Close();
                    // Exit loop
                    return;
                }
            }
        }

        /// <summary>
        /// Constructs a default StoreForm
        /// </summary>
        public StoreForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds item to the listbox.
        /// </summary>
        /// <param name="item"> String representation of item. </param>
        public void AddItem(string item)
        {
            itemListBox.Items.Add(item);

            // Update count label
            itemCountLabel.Text = $"There are " +
                $"{itemListBox.Items.Count - 1} items in this file.";
        }

        /// <summary>
        /// Removes an item at the specified index.
        /// </summary>
        public void RemoveItem(){

            // Do not remove header row and prevent deletion at -1
            if (itemListBox.SelectedIndex > 0)
            {
                itemListBox.Items.RemoveAt(itemListBox.SelectedIndex);

                // Update count label
                itemCountLabel.Text = $"There are " +
                    $"{itemListBox.Items.Count - 1} items in this file.";
            }
        }

        /// <summary>
        /// Save the listbox contents to the file.
        /// </summary>
        public void SaveData()
        {
            // Reset file for writing
            FileStream output = new FileStream(FileName, FileMode.Truncate, 
                FileAccess.Write);
            output.Seek(0, SeekOrigin.Begin);

            // Binary formatter to serialize data to file
            BinaryFormatter writer = new BinaryFormatter();

            // Save all listbox items to file
            for(int i = 1; i < itemListBox.Items.Count; i++) 
            {
                string recordString = itemListBox.Items[i].ToString();
                string[] recordData = recordString.Split('\t');
                
                // Create record using dat from listbox item
                Record record = new Record{
                    ID = int.Parse(recordData[0]),
                    Name = $"{recordData[1]}",
                    Store = $"{Text}",
                    Price = double.Parse(recordData[2]),
                    Quantity = int.Parse(recordData[3])
                };

                // Serialize data to file
                writer.Serialize(output, record);
            }
            // Close file
            output.Close();
        }
    }
}
