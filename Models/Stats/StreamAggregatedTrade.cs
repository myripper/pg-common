using System;
using System.Collections.Generic;

namespace PgCommon.Models.Stats
{
    public partial class StreamAggregatedTrade
    {
        public long? AggregateTradeId { get; set; }
        public bool? BuyerIsMaker { get; set; }
        public string Event { get; set; }
        public DateTime? EventTime { get; set; }
        public long? FirstTradeId { get; set; }
        public bool? Ignore { get; set; }
        public long? LastTradeId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public string Symbol { get; set; }
        public DateTime? TradeTime { get; set; }
    }
}
