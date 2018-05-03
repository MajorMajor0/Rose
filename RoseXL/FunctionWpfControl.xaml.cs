using Microsoft.Office.Tools.Excel;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
//using ExcelDna.Utilities;

namespace RoseXL
{
	/// <summary>
	/// Interaction logic for TaskPaneContent.xaml
	/// </summary>
	public partial class FunctionWpfControl : UserControl
	{

		Excel.Application ExcelApp;

		public FunctionWpfControl()
		{
			ExcelApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
			DataContext = new FunctionViewModel(ExcelApp);
			InitializeComponent();
		}
	}
}