namespace Program8MDI
{
    partial class StoreForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoLabel = new System.Windows.Forms.Label();
            this.itemCountLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(166, 25);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(313, 24);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Below are store and item details.";
            // 
            // itemCountLabel
            // 
            this.itemCountLabel.AutoSize = true;
            this.itemCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCountLabel.Location = new System.Drawing.Point(175, 97);
            this.itemCountLabel.Name = "itemCountLabel";
            this.itemCountLabel.Size = new System.Drawing.Size(287, 24);
            this.itemCountLabel.TabIndex = 1;
            this.itemCountLabel.Text = "There are 0 items in this store";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(89, 157);
            this.itemListBox.MultiColumn = true;
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(480, 134);
            this.itemListBox.TabIndex = 2;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 407);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.itemCountLabel);
            this.Controls.Add(this.infoLabel);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label itemCountLabel;
        private System.Windows.Forms.ListBox itemListBox;
    }
}