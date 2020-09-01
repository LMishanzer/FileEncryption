namespace FileEncryption
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.destinationBox = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.sourceChooseButton = new System.Windows.Forms.Button();
            this.destinationChooseButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(34, 25);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(54, 20);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Source";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(34, 117);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(85, 20);
            this.destinationLabel.TabIndex = 0;
            this.destinationLabel.Text = "Destination";
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(34, 59);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(299, 27);
            this.sourceBox.TabIndex = 1;
            // 
            // destinationBox
            // 
            this.destinationBox.Location = new System.Drawing.Point(34, 159);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(299, 27);
            this.destinationBox.TabIndex = 1;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(539, 59);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(133, 27);
            this.keyBox.TabIndex = 1;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(539, 25);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(33, 20);
            this.keyLabel.TabIndex = 0;
            this.keyLabel.Text = "Key";
            // 
            // sourceChooseButton
            // 
            this.sourceChooseButton.Location = new System.Drawing.Point(369, 58);
            this.sourceChooseButton.Name = "sourceChooseButton";
            this.sourceChooseButton.Size = new System.Drawing.Size(104, 27);
            this.sourceChooseButton.TabIndex = 2;
            this.sourceChooseButton.Text = "Choose...";
            this.sourceChooseButton.UseVisualStyleBackColor = true;
            this.sourceChooseButton.Click += new System.EventHandler(this.sourceChooseButton_Click);
            // 
            // destinationChooseButton
            // 
            this.destinationChooseButton.Location = new System.Drawing.Point(369, 159);
            this.destinationChooseButton.Name = "destinationChooseButton";
            this.destinationChooseButton.Size = new System.Drawing.Size(104, 27);
            this.destinationChooseButton.TabIndex = 2;
            this.destinationChooseButton.Text = "Choose...";
            this.destinationChooseButton.UseVisualStyleBackColor = true;
            this.destinationChooseButton.Click += new System.EventHandler(this.destinationChooseButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(539, 127);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(133, 58);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 224);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.destinationChooseButton);
            this.Controls.Add(this.sourceChooseButton);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.sourceLabel);
            this.Name = "MainForm";
            this.Text = "Best encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.TextBox destinationBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button sourceChooseButton;
        private System.Windows.Forms.Button destinationChooseButton;
        private System.Windows.Forms.Button encryptButton;
    }
}

