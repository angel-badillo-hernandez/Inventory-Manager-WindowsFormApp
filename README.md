# Inventory Manager

**Inventory Manager** is a Visual C# .NET Windows Forms application built with **C#** and **.NET 7.0**, developed using **Visual Studio**. This MDI (Multiple Document Interface) application allows users to open, read, and modify inventory data stored in binary format. It supports multiple inventory files opened simultaneously in separate child forms, each allowing users to view and edit the inventory data.

## Features

- **Open and Edit Files**: Open inventory data files in binary format and modify the data.
- **Multiple Windows**: Manage multiple inventory files at once with MDI support, displaying each inventory in its own window.
- **Data Management**: Add, modify, and remove items from the inventory list.
- **Save Files**: Save changes made to the inventory data back to the original files.
- **User-Friendly Interface**: Simple menu options for opening, saving, and editing files, along with an easy-to-use interface for interacting with the inventory.

## Project Structure

The project contains two main folders:

1. **MDI Application Folder**: Contains the main MDI Windows Form application, which is responsible for managing the inventory data and displaying multiple child forms.
   
2. **ItemForm Class Folder**: Contains the `ItemForm` class, which is used to display the details of an individual inventory item. This class is designed to be converted into a DLL (Dynamic Link Library) file that can be utilized within the main MDI application to manage the display and manipulation of item data.

## Requirements

- **Operating System**: Windows
- **.NET Version**: .NET 7.0 or higher
- **Development Environment**: Visual Studio

## How to Use

1. **Open Inventory Files**: Use the "File" menu to open an existing inventory file or create a new one.
2. **Manage Items**: Add, edit, or remove inventory items through the user-friendly interface.
3. **Save Changes**: Save your modified inventory back to the file with the "Save" option.
