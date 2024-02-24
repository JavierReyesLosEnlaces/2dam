namespace ClassLibrary1
{
    public class SalesLine
    {
        // 2 clases para el conjunto de datos: SalesLine y SalesLineDS
        public String CustAccount {get;set;}
        public String CustName { get; set; }
        public String ItemId { get; set; }
        public String Description { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class  SalesLineDS
    {
        public static List<SalesLine> getSalesLine()
        {
            var customers = constructCostumers();
            var items = constructItems();

            var res = new List<SalesLine>();

            var rndGenerator = new Random();
            for (int i = 1; i<=25;i++)
            {
                var rndCustomers = "C0000" + rndGenerator.Next(1, 11);
                var rndItem = "0000" + rndGenerator.Next(1, 11);
                var rndQty = rndGenerator.NextDouble() * 100;
                var rndUnitPrice = rndGenerator.NextDouble() + 100;

                var salesLine = new SalesLine();

                salesLine.CustAccount = rndCustomers;
                salesLine.CustName = customers[rndCustomers];
                salesLine.ItemId = rndItem;
                salesLine.Description = items[rndItem];
                salesLine.Qty = (decimal)rndQty;
                salesLine.UnitPrice = (decimal) rndUnitPrice;
                salesLine.TotalPrice = salesLine.Qty * salesLine.UnitPrice;

                res.Add(salesLine);
            }
            return res;
        }

        private static Dictionary<string, string> constructCostumers()
        {
            var clientes = new Dictionary<string, string>()
            {
                { "C00001", "Hammond"},
                { "C00002", "Dever Lecs"},
                { "C00003", "J Nemonic"},
                { "C00004", "J Masics"},
                { "C00005", "LordieLord"},
                { "C00006", "Stan Inc"},
                { "C00007", "Kenny Ltd"},
                { "C00008", "Cartman Co"},
                { "C00009", "Marv Fun"},
                { "C000010", "Kyle Vidiclub"},
                { "C000011", "BGH in Madrid"},
                { "C000012", "Smt Smt"},
            };
            return clientes;
        }

        private static Dictionary<string, string> constructItems()
        {
            var items = new Dictionary<string, string>()
            {
                { "00001", "Model 1"},
                { "00002", "Model 2"},
                { "00003", "Model 3"},
                { "00004", "Model 4"},
                { "00005", "Model 5"},
                { "00006", "Model 6"},
                { "00007", "Model 7"},
                { "00008", "Model 8"},
                { "00009", "Model 9"},
                { "000010", "Model 10"},
                { "000011", "Model 11"},
                { "000012", "Model 12"},
            };
            return items;
        }
    }
}
