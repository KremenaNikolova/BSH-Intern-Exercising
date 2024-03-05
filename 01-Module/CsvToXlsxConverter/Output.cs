namespace CsvToXlsxConverter
{
    public class Output
    {
        public static string GetOutput()
        {
            Console.WriteLine("Please enther name of the .xlsx file");
            string newFileName = Console.ReadLine()!;
            string excelFilePath = $"..\\..\\..\\{newFileName}.xlsx";

            while (File.Exists(excelFilePath))
            {
                Console.WriteLine("File with that name already exist. \n" + "Please try with another name!");
                newFileName = Console.ReadLine()!;
                excelFilePath = $"..\\..\\..\\{newFileName}.xlsx";
            }


            return excelFilePath;
        }
    }
}
