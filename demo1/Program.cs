using ClosedXML.Excel;
using System;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            writeexcel();   
        }

        public static  void writeexcel() {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Demo Sheet");
            worksheet.Cell("A1").Value = "Hello ClosedXML";
            worksheet.Cell("A2").FormulaA1 = "=MID(A1,7,5)";
            // workbook.SaveAs(".\\output\\DemowriteExcel.xlsx");
            workbook.SaveAs("DemowriteExcel.xlsx");
        }
    }
}
