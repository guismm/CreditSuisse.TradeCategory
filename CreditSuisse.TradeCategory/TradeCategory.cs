namespace CreditSuisse.TradeCategory
{
    public abstract class TradeCategory
    {
        public abstract string Name { get;  }
        public abstract bool IsMatch(ITrade trade, DateTime referenceDate);
    }

    public class ExpiredCategory : TradeCategory
    {
        public override string Name => "EXPIRED";

        public override bool IsMatch(ITrade trade, DateTime referenceDate)
        {
            return (referenceDate - trade.NextPaymentDate).Days > 30;
        }
    }

    public class HighRiskCategory : TradeCategory
    {
        public override string Name => "HIGHRISK";

        public override bool IsMatch(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1_000_000 && trade.ClientSector == "Private"; 
        }
    }

    public class MediumRiskCategory : TradeCategory
    {
        public override string Name => "MEDIUMRISK";

        public override bool IsMatch(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1_000_000 && trade.ClientSector == "Public";
        }
    }
}
