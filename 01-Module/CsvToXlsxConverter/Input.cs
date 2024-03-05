namespace CsvToXlsxConverter
{
    public class Input
    {
        public static string GetFile()
        {
            Console.WriteLine("Please enter the .csv File Path!");
            string file = Console.ReadLine()!;

            while (!File.Exists(file))
            {
                Console.WriteLine("Wrong File Path \n" + "Please enter valid File Path!");
                file = Console.ReadLine()!;
            }


            return file;
        }
    }
}
