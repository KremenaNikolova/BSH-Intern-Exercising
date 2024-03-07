namespace CsvToXlsxConverter
{
    using OfficeOpenXml;
    using System.Globalization;

    public class Converter
    {
        public void ConvertCsvToExcel(string csvFilePath, string excelFilePath)
        {
            FileInfo excelFile = new FileInfo(excelFilePath);

            using ExcelPackage package = new ExcelPackage(excelFile);

            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

            string[] csvLines = File.ReadAllLines(csvFilePath);

            int row = 1;
            foreach (string csvLine in csvLines)
            {
                string[] fields = csvLine.Split('|');
                for (int i = 0; i < fields.Length; i++)
                {
                    string dateTimeFormat = "dd/MM/yyyy";
                    bool isValidDate = DateTime.TryParseExact(fields[i], dateTimeFormat, CultureInfo.InvariantCulture ,DateTimeStyles.None, out DateTime date);

                    if (isValidDate)
                    {
                        worksheet.Cells[row, i + 1].Value = date;
                    }
                    else
                    {
                        worksheet.Cells[row, i + 1].Value = fields[i];
                    }
                    
                }
                row++;
            }

            package.Save();
        }
    }
}
