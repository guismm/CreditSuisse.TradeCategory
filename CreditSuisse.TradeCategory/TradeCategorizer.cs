namespace CreditSuisse.TradeCategory
{
    public class TradeCategorizer
    {
        private readonly List<TradeCategory> categories;

        public TradeCategorizer()
        {
            categories = new List<TradeCategory>
            {
                new ExpiredCategory(),
                new HighRiskCategory(),
                new MediumRiskCategory(),
            };
        }

        public string Categorize(ITrade trade, DateTime referenceDate)
        {
            foreach (var category in categories)
            {
                if (category.IsMatch(trade, referenceDate))
                {
                    return category.Name;
                }
            }

            return "NO CATEGORY";
        }
    }
}
