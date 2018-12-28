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
            priceChart.Series.Clear();
            priceChart.Series.Add("Ticker");
            priceChart.Series["Ticker"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            priceChart.Series["Ticker"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            priceChart.Series["Ticker"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
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
                priceChart.DataSource = values;
                priceChart.Series["Ticker"].XValueMember = "PriceDate";
                priceChart.Series["Ticker"].YValueMembers = "PriceClose";
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
