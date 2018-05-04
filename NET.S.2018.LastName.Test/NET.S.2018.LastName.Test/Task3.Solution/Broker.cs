using System;

namespace Task3.Solution
{
    public class Broker
    {
        public string Name { get; set; }
        private Stock _stock;

        public Broker(string name, Stock stock)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            this.Name = name;
            this._stock = stock ?? throw new ArgumentNullException(nameof(stock));
            this._stock.MarketChanged += Update;
        }

        public void Update(object info, StockInfoEventArgs stockInfo)
        {
            StockInfo sInfo = (StockInfo)info;
            this._stock.Market(this, new StockInfoEventArgs(sInfo.USD, sInfo.Euro));

            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }

        public void StopTrade()
        {
            this._stock.MarketChanged -= Update;
        }
    }
}