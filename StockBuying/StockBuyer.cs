namespace StockBuying
{
    public class StockBuyer : IPriceListener
    {
        private readonly IStockExchange stockExchange;

        public StockBuyer(IStockExchange stockExchange)
        {
            this.stockExchange = stockExchange;
        }

        //TODO: implement this method
        public void PriceTick(string stockTicker, decimal price)
        {
            throw new System.NotImplementedException();
        }
    }
}