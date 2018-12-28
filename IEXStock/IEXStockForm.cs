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

namespace IEXStock
{
    public partial class IEXStockForm : Form
    {
        private string iexUrlBase = "https://api.iextrading.com/1.0";
        public IEXStockForm()
        {
            InitializeComponent();
        }

        private async void retrieveButton_Click(object sender, EventArgs e)
        {
            string ticker = tickerText.Text;

            JObject tickerData = await RetrieveEquityData(ticker);

            resultsText.Lines = tickerData.ToString().Split(new char[] { '\n' });
        }

        private async Task<JObject> RetrieveEquityData(string ticker)
        {
            JObject result;
            HttpClient client = new HttpClient();
            string quoteUrl = iexUrlBase + "/stock/market/batch?types=ohlc,price&symbols=" + ticker;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage msg = await client.GetAsync(quoteUrl);

            if (msg.IsSuccessStatusCode)
            {
                string resp = await msg.Content.ReadAsStringAsync();
                result = JObject.Parse(resp);
            }
            else
            {
                result = JObject.Parse("{'error': '" +  msg.StatusCode.ToString() + "'}" );
            }
            return result;
        }
    }
}
