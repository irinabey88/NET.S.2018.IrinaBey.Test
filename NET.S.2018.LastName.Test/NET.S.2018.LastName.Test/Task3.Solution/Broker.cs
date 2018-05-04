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

        public void Update(object sender, StockInfoEventArgs stockInfo)
        {                   
            if (stockInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
        }

        public void StopTrade()
        {
            this._stock.MarketChanged -= Update;
        }
    }
}