## Task:

1.	Ask the user for the path to the .csv file.
2.	Load the file and read the data from it.
3.	Process the data and save it in an Excel file on your file system. Each row of the csv file should be a separate row in your Excel file. The values that should go in the individual columns are separated with a “|” sign.


## Solution:

The best way in my opinion is to use EPPlus package.
It helps to read cvs files and covert it to xlsx easly.

This is documentation which I use <a href='https://github.com/EPPlusSoftware/EPPlus/wiki/LoadFromText'>EPPlus Read and Load files</a> and <a href='https://github.com/EPPlusSoftware/EPPlus/wiki/SaveToText'>EPPlus Save files</a> .

If want to use EPPlus in a noncommercial context, write this line in begin of your Program.cs

`ExcelPackage.LicenseContext = LicenseContext.NonCommercial;`
