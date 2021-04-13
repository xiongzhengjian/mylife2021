using ClosedXML.Excel;
using System;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //writeexcel();
            //arraytest();
            MathematicalTools mathtools = new MathematicalTools();
            //long factorialresult = mathtools.factorial(3);
            long factorialresult = mathtools.combination(6,3);
            Console.WriteLine("10结果为:{0}",factorialresult);

        }

        public static  void writeexcel() {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Demo Sheet");
            worksheet.Cell("A1").Value = "Hello ClosedXML";
            worksheet.Cell("A2").FormulaA1 = "=MID(A1,7,5)";
            // workbook.SaveAs(".\\output\\DemowriteExcel.xl`sx");
            workbook.SaveAs("DemowriteExcel.xlsx");
           
        }

        public static void readexcel() { 
            
        }

        public static void arraytest() {
            int[] n = new int[10];
            for (int i=0;i<10;i++) {
                n[i] = i + 100;
            }
            foreach (int j in n) {
                int i = j - 100;
                Console.WriteLine("Element[{0}]=[1]",i,j);
            }
        }
    }
}
