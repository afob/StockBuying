namespace StockBuying
{

    // do not modify this calss
    public class StockExchange : IStockExchange
    {
        public void Buy(string stockTicker, int quantity)
        {
            throw new System.Exception("You are not connected to the stock exchange!");
        }
    }
}