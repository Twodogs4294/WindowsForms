//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;
//using MSWord = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Core;
//using System.IO;

using ClosedXML.Excel;
using System;


public class ReadAndWrite
{
	public ReadAndWrite()
	{
		
	}

	public void CreatExcel(string filePath)
	{
		var workbook = new XLWorkbook();
		var worksheet = workbook.Worksheets.Add("Equipment");
		worksheet.Cell("A1").Value = "ID";
		workbook.SaveAs(filePath);
	}
}
