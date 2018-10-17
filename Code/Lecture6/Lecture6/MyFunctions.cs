using ExcelDna.Integration;

namespace TestExcelDNA
{
    public static class MyFunctions
    {
        [ExcelFunction(Description = "My first .NET function")]
        public static string SayHello(
            [ExcelArgument(Description = "Input string")]
            string name)
        {
            return "Hello " + name;
        }
    }
}