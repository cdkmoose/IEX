using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace IEXPriceChart
{
    public partial class IEXPriceChartForm : Form
    {
        private string iexUrlBase = "https://api.iextrading.com/1.0";

        public IEXPriceChartForm()
        {
            InitializeComponent();
        }

        private void IEXPriceChartForm_Load(object sender, EventArgs e)
        {
            priceChart.Titles.Add("Price History");
            priceChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            priceChart.Series.Clear();
        }

        private async void chartButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tickerText.Text))
            {
                MessageBox.Show("You must enter a ticker for chari=ting.");
                tickerText.Focus();
                return;
            }

            List<IEXChartDataPoint> values = await GetPriceData(tickerText.Text);
            if (values != null)
            {
                priceChart.Series.Add("Close");
                priceChart.Series["Close"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                priceChart.Series["Close"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                priceChart.Series["Close"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                priceChart.Series["Close"].XValueMember = "PriceDate";
                priceChart.Series["Close"].YValueMembers = "PriceClose";
                priceChart.Series["Close"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
                priceChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = priceChart.Series["Close"].Color = Color.Blue;
                priceChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                priceChart.Series.Add("Volume");
                priceChart.Series["Volume"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                priceChart.Series["Volume"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                priceChart.Series["Volume"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                priceChart.Series["Volume"].XValueMember = "PriceDate";
                priceChart.Series["Volume"].YValueMembers = "Volume";
                priceChart.Series["Volume"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                priceChart.ChartAreas[0].AxisY2.LabelStyle.ForeColor = priceChart.Series["Volume"].Color = Color.Green;
                priceChart.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;

                priceChart.DataSource = values;
                priceChart.DataBind();


            }
        }

        private async Task<List<IEXChartDataPoint>> GetPriceData(string ticker)
        {
            List<IEXChartDataPoint> result = null;
            HttpClient client = new HttpClient();
            string quoteUrl = iexUrlBase + "/stock/" + ticker + "/chart/1y";
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage msg = await client.GetAsync(quoteUrl);

            if (msg.IsSuccessStatusCode)
            {
                string resp = await msg.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<IEXChartDataPoint>>(resp);
            }

            return result;

        }

    }
}
