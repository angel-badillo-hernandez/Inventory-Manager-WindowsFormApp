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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemForm
{
    /// <summary>
    /// A simple class for creating/storing serializable information
    /// to files in binary format.
    /// </summary>
    [Serializable]
    public class Record
    {
        /// <summary>
        /// Constructs Record with default data.
        /// </summary>
        public Record(): this(0, string.Empty, string.Empty, 0.0, 0){}

        /// <summary>
        /// Constructs Record using given parameters.
        /// </summary>
        /// <param name="id"> ID of item. </param>
        /// <param name="name"> Name of item. </param>
        /// <param name="store"> Name of store. </param>
        /// <param name="price"> Price of item. </param>
        /// <param name="quantity"> Quantity of item. </param>
        public Record(int id, string name, string store, double price, 
            int quantity)
        {
            ID = id;
            Name = name;
            Store = store;
            Price = price;
            Quantity = quantity;
        }

        // ID of item
        public int ID { get; set; }

        // Name of item
        public string Name { get; set; }

        // Price of item
        public double Price { get; set; }

        // Number of that item
        public int Quantity { get; set; }

        // Store item is from
        public string Store { get; set; }
    }
}