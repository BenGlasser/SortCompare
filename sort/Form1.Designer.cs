namespace sort
{
    partial class SortCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortCompare));
            this.insertionButton = new System.Windows.Forms.Button();
            this.selectionButton = new System.Windows.Forms.Button();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.mixUpButton = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.binaryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // insertionButton
            // 
            this.insertionButton.Location = new System.Drawing.Point(13, 234);
            this.insertionButton.Name = "insertionButton";
            this.insertionButton.Size = new System.Drawing.Size(126, 41);
            this.insertionButton.TabIndex = 1;
            this.insertionButton.Text = "Insertion";
            this.insertionButton.UseVisualStyleBackColor = true;
            this.insertionButton.Click += new System.EventHandler(this.insertionButton_Click);
            // 
            // selectionButton
            // 
            this.selectionButton.Location = new System.Drawing.Point(13, 281);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(126, 41);
            this.selectionButton.TabIndex = 2;
            this.selectionButton.Text = "Selection";
            this.selectionButton.UseVisualStyleBackColor = true;
            this.selectionButton.Click += new System.EventHandler(this.selectionButton_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.Location = new System.Drawing.Point(13, 328);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(126, 41);
            this.bubbleButton.TabIndex = 3;
            this.bubbleButton.Text = "Bubble";
            this.bubbleButton.UseVisualStyleBackColor = true;
            this.bubbleButton.Click += new System.EventHandler(this.bubbleButton_Click);
            // 
            // mixUpButton
            // 
            this.mixUpButton.ForeColor = System.Drawing.Color.Red;
            this.mixUpButton.Location = new System.Drawing.Point(13, 13);
            this.mixUpButton.Name = "mixUpButton";
            this.mixUpButton.Size = new System.Drawing.Size(125, 113);
            this.mixUpButton.TabIndex = 7;
            this.mixUpButton.Text = "Mix Up!";
            this.mixUpButton.UseVisualStyleBackColor = true;
            this.mixUpButton.Click += new System.EventHandler(this.mixUpButton_Click);
            // 
            // outBox
            // 
            this.outBox.FormattingEnabled = true;
            this.outBox.Location = new System.Drawing.Point(12, 533);
            this.outBox.Name = "outBox";
            this.outBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.outBox.Size = new System.Drawing.Size(642, 69);
            this.outBox.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(144, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(510, 510);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // binaryButton
            // 
            this.binaryButton.Location = new System.Drawing.Point(13, 376);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(126, 41);
            this.binaryButton.TabIndex = 10;
            this.binaryButton.Text = "Binary";
            this.binaryButton.UseVisualStyleBackColor = true;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // SortCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(675, 612);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.mixUpButton);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.selectionButton);
            this.Controls.Add(this.insertionButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortCompare";
            this.Text = "Sorting Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertionButton;
        private System.Windows.Forms.Button selectionButton;
        private System.Windows.Forms.Button bubbleButton;
        private System.Windows.Forms.Button mixUpButton;
        private System.Windows.Forms.ListBox outBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button binaryButton;
    }
}

