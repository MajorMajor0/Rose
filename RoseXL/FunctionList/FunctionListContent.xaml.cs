using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
//using ExcelDna.Utilities;

namespace FunctionList
{
	/// <summary>
	/// Interaction logic for TaskPaneContent.xaml
	/// </summary>
	public partial class FunctionListContent: UserControl
	{

		Excel.Application ExcelApp;

		public FunctionListContent()
		{
			ExcelApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
			InitializeComponent();
		}

		private void ConvertButton_Click(object sender, RoutedEventArgs e)
		{
			if (ExcelApp.ActiveCell != null)
			{
				ExcelApp.ActiveCell.Value = 2;
			}

			MessageBox.Show("You clicked the button.");
		}

	}
}