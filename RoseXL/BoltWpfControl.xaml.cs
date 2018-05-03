using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;

namespace RoseXL
{
	/// <summary>
	/// Interaction logic for TaskPaneContent.xaml
	/// </summary>
	public partial class BoltWpfControl : UserControl
	{
		Excel.Application ExcelApp;

		List<Rose.Thread> preferredThreads => Rose.Threads.List.Where(x => x.MajorBasic < 1 && x.MajorBasic > .249 && x.Class == "2B" && (x.Series == "UNF" || x.Series == "UNC")).ToList();

		public BoltWpfControl()
		{
			ExcelApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
			InitializeComponent();
			ThreadDataComboBox.ItemsSource = preferredThreads;
		}

		void MyButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			if (ExcelApp.ActiveCell != null)
			{
				ExcelApp.ActiveCell.Value = 2;
			}

			MessageBox.Show("You clicked the button.");
		}

		private void ThreadDataComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}