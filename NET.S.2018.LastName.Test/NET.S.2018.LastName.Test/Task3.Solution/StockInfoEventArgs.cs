using System;

namespace Task3.Solution
{
    public class StockInfoEventArgs : EventArgs
    {
        private int _usd;
        private int _euro;

        public StockInfoEventArgs(int usd, int euro)
        {
            this._usd = usd;
            this._euro = euro;
        }

        public int USD  => this._usd;
        public int Euro => this._euro;
    }
}
