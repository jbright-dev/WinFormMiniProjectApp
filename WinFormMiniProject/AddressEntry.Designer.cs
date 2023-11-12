namespace WinFormMiniProject
{
    partial class AddressEntry
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
            this.cityText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.addressEntryLabel = new System.Windows.Forms.Label();
            this.saveAddressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(203, 139);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(411, 37);
            this.cityText.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(137, 139);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(60, 30);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(203, 96);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(411, 37);
            this.streetAddressText.TabIndex = 5;
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(18, 99);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(179, 30);
            this.streetAddressLabel.TabIndex = 4;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(124, 185);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(73, 30);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(203, 182);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(411, 37);
            this.stateText.TabIndex = 5;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(75, 228);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(122, 30);
            this.zipCodeLabel.TabIndex = 3;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(203, 225);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(411, 37);
            this.zipCodeText.TabIndex = 6;
            // 
            // addressEntryLabel
            // 
            this.addressEntryLabel.AutoSize = true;
            this.addressEntryLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressEntryLabel.Location = new System.Drawing.Point(196, 22);
            this.addressEntryLabel.Name = "addressEntryLabel";
            this.addressEntryLabel.Size = new System.Drawing.Size(243, 41);
            this.addressEntryLabel.TabIndex = 7;
            this.addressEntryLabel.Text = "Address Entry";
            // 
            // saveAddressButton
            // 
            this.saveAddressButton.Location = new System.Drawing.Point(203, 280);
            this.saveAddressButton.Name = "saveAddressButton";
            this.saveAddressButton.Size = new System.Drawing.Size(230, 39);
            this.saveAddressButton.TabIndex = 8;
            this.saveAddressButton.Text = "Save";
            this.saveAddressButton.UseVisualStyleBackColor = true;
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 331);
            this.Controls.Add(this.saveAddressButton);
            this.Controls.Add(this.addressEntryLabel);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.streetAddressLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddressEntry";
            this.Text = "Address Entry Form by Jason Bright";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetAddressText;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.Label addressEntryLabel;
        private System.Windows.Forms.Button saveAddressButton;
    }
}