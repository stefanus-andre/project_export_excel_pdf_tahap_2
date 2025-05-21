using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml; 
using System.IO;
using Rotativa.AspNetCore;

namespace project_excel.Controllers
{
    public class ExportController : Controller
    {
        [HttpGet]
        public IActionResult ExportExcel()
        {
            var stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("Data");
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Nama";
                worksheet.Cells[1, 3].Value = "Umur";

                worksheet.Cells[2, 1].Value = 1;
                worksheet.Cells[2, 2].Value = "Stefanus";
                worksheet.Cells[2, 3].Value = 29;
                
                package.Save();
            }

            stream.Position = 0;
            string excelName = $"Export-{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
        }

        [HttpGet]
        public IActionResult ExportPDF()
        {
            return new ViewAsPdf("ExportPdf")
            {
                FileName = "TestReport.pdf"
                
            };
        }
    }
}
