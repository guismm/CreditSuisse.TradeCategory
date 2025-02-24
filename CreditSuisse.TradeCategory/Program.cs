using CreditSuisse.TradeCategory;

// Read reference date
DateTime referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

// Read number of trades
int n = int.Parse(Console.ReadLine());

var trades = new List<ITrade>();
for (int i = 0; i < n; i++)
{
    string[] tradeData = Console.ReadLine().Split(' ');
    double value = double.Parse(tradeData[0]);
    string clientSector = tradeData[1];
    DateTime nextPaymentDate = DateTime.ParseExact(tradeData[2], "MM/dd/yyyy", null);

    trades.Add(new Trade(value, clientSector, nextPaymentDate));
}

// Categorize trades
var categorizer = new TradeCategorizer();
foreach (var trade in trades)
{
    string category = categorizer.Categorize(trade, referenceDate);
    Console.WriteLine(category);
}
