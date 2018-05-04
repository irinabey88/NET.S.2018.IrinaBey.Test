using System;

namespace Task3.Solution
{
    public class Stock
    {
        private StockInfo _stocksInfo;

        public event EventHandler<StockInfoEventArgs> MarketChanged;

        public Stock()
        {
            _stocksInfo = new StockInfo();
        }

        protected void OnMarketChanged(StockInfoEventArgs eventArgs)
        {
            if (eventArgs == null)
            {
                throw new ArgumentNullException(nameof(eventArgs));
            }

            MarketChanged?.Invoke(this, eventArgs);
        }

        public void Market(object sender, StockInfoEventArgs eventArgs)
        {
            Random rnd = new Random();
            OnMarketChanged(new StockInfoEventArgs(rnd.Next(20, 40), rnd.Next(30, 50)));
        }
    }
}