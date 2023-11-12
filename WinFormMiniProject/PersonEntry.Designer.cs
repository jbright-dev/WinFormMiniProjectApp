namespace WinFormMiniProject
{
    partial class PersonEntry
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressesList = new System.Windows.Forms.ListBox();
            this.addressesListLabel = new System.Windows.Forms.Label();
            this.addNewAddressButton = new System.Windows.Forms.Button();
            this.saveRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(54, 82);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(137, 30);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(197, 79);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(411, 37);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(54, 125);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(139, 30);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(197, 122);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(411, 37);
            this.lastNameText.TabIndex = 1;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(197, 180);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(15, 14);
            this.isActive.TabIndex = 2;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(79, 164);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(91, 30);
            this.isActiveLabel.TabIndex = 0;
            this.isActiveLabel.Text = "Active";
            // 
            // addressesList
            // 
            this.addressesList.FormattingEnabled = true;
            this.addressesList.ItemHeight = 30;
            this.addressesList.Location = new System.Drawing.Point(59, 253);
            this.addressesList.Name = "addressesList";
            this.addressesList.Size = new System.Drawing.Size(549, 214);
            this.addressesList.TabIndex = 3;
            // 
            // addressesListLabel
            // 
            this.addressesListLabel.AutoSize = true;
            this.addressesListLabel.Location = new System.Drawing.Point(54, 220);
            this.addressesListLabel.Name = "addressesListLabel";
            this.addressesListLabel.Size = new System.Drawing.Size(131, 30);
            this.addressesListLabel.TabIndex = 0;
            this.addressesListLabel.Text = "Addresses";
            // 
            // addNewAddressButton
            // 
            this.addNewAddressButton.Location = new System.Drawing.Point(93, 473);
            this.addNewAddressButton.Name = "addNewAddressButton";
            this.addNewAddressButton.Size = new System.Drawing.Size(230, 39);
            this.addNewAddressButton.TabIndex = 4;
            this.addNewAddressButton.Text = "Add";
            this.addNewAddressButton.UseVisualStyleBackColor = true;
            // 
            // saveRecordButton
            // 
            this.saveRecordButton.Location = new System.Drawing.Point(348, 473);
            this.saveRecordButton.Name = "saveRecordButton";
            this.saveRecordButton.Size = new System.Drawing.Size(230, 39);
            this.saveRecordButton.TabIndex = 4;
            this.saveRecordButton.Text = "Save";
            this.saveRecordButton.UseVisualStyleBackColor = true;
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 551);
            this.Controls.Add(this.saveRecordButton);
            this.Controls.Add(this.addNewAddressButton);
            this.Controls.Add(this.addressesList);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.addressesListLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form by Jason Bright";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.Label addressesListLabel;
        private System.Windows.Forms.Button addNewAddressButton;
        private System.Windows.Forms.Button saveRecordButton;
    }
}

