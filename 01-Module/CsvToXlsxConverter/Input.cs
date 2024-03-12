namespace CsvToXlsxConverter
{
    using static ExceptionMessages;
    public class Input
    {
        public static string GetFile()
        {
            Console.WriteLine("Please enter the .csv File Path!");
            string file = Console.ReadLine()!;

            try
            {
                while (!File.Exists(file))
                {
                    Console.WriteLine("Wrong File Path \n" + "Please enter valid File Path!");
                    file = Console.ReadLine()!;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine(SomethingGetWrongMessage);
                return GetFile();
            }
            catch (Exception)
            {
                return WrongInputMessage;
            }


            return file;
        }
    }
}
