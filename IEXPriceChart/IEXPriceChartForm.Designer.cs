namespace IEXPriceChart
{
    partial class IEXPriceChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tickerText = new System.Windows.Forms.TextBox();
            this.priceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(448, 31);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(75, 23);
            this.chartButton.TabIndex = 0;
            this.chartButton.Text = "LoadChart";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticker";
            // 
            // tickerText
            // 
            this.tickerText.Location = new System.Drawing.Point(187, 33);
            this.tickerText.Name = "tickerText";
            this.tickerText.Size = new System.Drawing.Size(100, 20);
            this.tickerText.TabIndex = 2;
            // 
            // priceChart
            // 
            chartArea4.Name = "ChartArea1";
            this.priceChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.priceChart.Legends.Add(legend4);
            this.priceChart.Location = new System.Drawing.Point(39, 109);
            this.priceChart.Name = "priceChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.priceChart.Series.Add(series4);
            this.priceChart.Size = new System.Drawing.Size(709, 410);
            this.priceChart.TabIndex = 3;
            this.priceChart.Text = "chart1";
            // 
            // IEXPriceChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 558);
            this.Controls.Add(this.priceChart);
            this.Controls.Add(this.tickerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartButton);
            this.Name = "IEXPriceChartForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IEXPriceChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tickerText;
        private System.Windows.Forms.DataVisualization.Charting.Chart priceChart;
    }
}

