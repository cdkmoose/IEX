namespace IEXStock
{
    partial class IEXStockForm
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
            this.tickerLabel = new System.Windows.Forms.Label();
            this.tickerText = new System.Windows.Forms.TextBox();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.resultsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Location = new System.Drawing.Point(56, 40);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(37, 13);
            this.tickerLabel.TabIndex = 0;
            this.tickerLabel.Text = "Ticker";
            // 
            // tickerText
            // 
            this.tickerText.Location = new System.Drawing.Point(119, 36);
            this.tickerText.Name = "tickerText";
            this.tickerText.Size = new System.Drawing.Size(112, 20);
            this.tickerText.TabIndex = 1;
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(264, 33);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveButton.TabIndex = 2;
            this.retrieveButton.Text = "Retrieve";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(94, 107);
            this.resultsText.Multiline = true;
            this.resultsText.Name = "resultsText";
            this.resultsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsText.Size = new System.Drawing.Size(464, 331);
            this.resultsText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.tickerText);
            this.Controls.Add(this.tickerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tickerLabel;
        private System.Windows.Forms.TextBox tickerText;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.TextBox resultsText;
    }
}

