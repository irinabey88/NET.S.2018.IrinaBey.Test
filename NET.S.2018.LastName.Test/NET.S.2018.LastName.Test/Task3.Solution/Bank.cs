using System;

namespace Task3.Solution
{
    public class Bank
    {
        public string Name { get; set; }
        private Stock _stock;

        public Bank(string name, Stock stock )
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            this.Name = name;
            this._stock = stock ?? throw new ArgumentNullException(nameof(stock));
            this._stock.MarketChanged += Update;

        }

        public void Update(object info, StockInfoEventArgs eventArgs)
        {
            StockInfo sInfo = (StockInfo)info;
            this._stock.Market(this, new StockInfoEventArgs(sInfo.USD, sInfo.Euro));
            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}