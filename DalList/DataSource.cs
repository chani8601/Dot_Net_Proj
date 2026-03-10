using DO;

namespace Dal
{
    internal static class DataSource
    {
        static internal List<Customer> customers = new();
        static internal List<Product> products = new();
        static internal List<Sale> sales=new();
        internal static class Config
        {
            internal const int ProductMinCode = 100;
            internal const int SaleMinCode =200;

            private static int ProductIndex= ProductMinCode;
            private static int SaleIndex = SaleMinCode;
            //private static int CustomerIndex;

            public static int ProductCode=>ProductIndex++;
            public static int SaleCode => SaleIndex ++;

        }
    }
}
