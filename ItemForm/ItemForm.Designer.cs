namespace ItemForm
{
    partial class ItemForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.itemIDLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ItemDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemDetailsGroupBox
            // 
            this.ItemDetailsGroupBox.Controls.Add(this.itemQuantityTextBox);
            this.ItemDetailsGroupBox.Controls.Add(this.itemPriceTextBox);
            this.ItemDetailsGroupBox.Controls.Add(this.itemNameTextBox);
            this.ItemDetailsGroupBox.Controls.Add(this.itemIDTextBox);
            this.ItemDetailsGroupBox.Controls.Add(this.itemQuantityLabel);
            this.ItemDetailsGroupBox.Controls.Add(this.itemPriceLabel);
            this.ItemDetailsGroupBox.Controls.Add(this.itemNameLabel);
            this.ItemDetailsGroupBox.Controls.Add(this.itemIDLabel);
            this.ItemDetailsGroupBox.Location = new System.Drawing.Point(22, 19);
            this.ItemDetailsGroupBox.Name = "ItemDetailsGroupBox";
            this.ItemDetailsGroupBox.Size = new System.Drawing.Size(402, 192);
            this.ItemDetailsGroupBox.TabIndex = 0;
            this.ItemDetailsGroupBox.TabStop = false;
            this.ItemDetailsGroupBox.Text = "Item Details";
            // 
            // itemIDLabel
            // 
            this.itemIDLabel.AutoSize = true;
            this.itemIDLabel.Location = new System.Drawing.Point(16, 30);
            this.itemIDLabel.Name = "itemIDLabel";
            this.itemIDLabel.Size = new System.Drawing.Size(41, 13);
            this.itemIDLabel.TabIndex = 0;
            this.itemIDLabel.Text = "Item ID";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(16, 74);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(16, 117);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.itemPriceLabel.TabIndex = 2;
            this.itemPriceLabel.Text = "Price";
            // 
            // itemQuantityLabel
            // 
            this.itemQuantityLabel.AutoSize = true;
            this.itemQuantityLabel.Location = new System.Drawing.Point(16, 152);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.itemQuantityLabel.TabIndex = 3;
            this.itemQuantityLabel.Text = "Quantity";
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.Location = new System.Drawing.Point(76, 30);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(261, 20);
            this.itemIDTextBox.TabIndex = 4;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(76, 74);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.itemNameTextBox.TabIndex = 5;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(76, 117);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(261, 20);
            this.itemPriceTextBox.TabIndex = 6;
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(76, 152);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(261, 20);
            this.itemQuantityTextBox.TabIndex = 7;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemDetailsGroupBox);
            this.Name = "ItemForm";
            this.Size = new System.Drawing.Size(448, 239);
            this.ItemDetailsGroupBox.ResumeLayout(false);
            this.ItemDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemDetailsGroupBox;
        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.Label itemQuantityLabel;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemIDLabel;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
    }
}
