namespace CsvToXlsxConverter
{
    using OfficeOpenXml;

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
                    worksheet.Cells[row, i + 1].Value = fields[i];
                }
                row++;
            }

            package.Save();
        }
    }
}
