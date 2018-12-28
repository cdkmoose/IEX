using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace IEXPriceChart
{
    public class IEXChartDataPoint
    {
        [JsonProperty("date")]
        public DateTime PriceDate { get; set; }

        [JsonProperty("open")]
        public double PriceOpen { get; set; }

        [JsonProperty("high")]
        public double PriceHigh { get; set; }

        [JsonProperty("low")]
        public double PriceLow { get; set; }

        [JsonProperty("close")]
        public double PriceClose { get; set; }

        [JsonProperty("volume")]
        public Int64 Volume { get; set; }

        [JsonProperty("unadjustedClose")]
        public double UnAdjPriceClose { get; set; }

        [JsonProperty("unadjustedVolume")]
        public Int64 UnAdjVolume { get; set; }

        [JsonProperty("change")]
        public double PriceChange { get; set; }

        [JsonProperty("changePercent")]
        public double PriceChangePercent { get; set; }

        [JsonProperty("vwap")]
        public double VWAP { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("changeOverTime")]
        public double ChangeOverTime { get; set; }
    }
}
