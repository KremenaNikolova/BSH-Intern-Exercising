namespace CsvToXlsxConverter
{
    using OfficeOpenXml;

    public class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string file = Input.GetFile();
            string output = Output.GetOutput();

            Converter converter = new Converter();
            converter.ConvertCsvToExcel(file, output);

            Console.WriteLine("CSV file has been converted to Excel successfully.");
        }

        
    }
}