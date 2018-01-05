using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.Office.Interop.Excel;


namespace Rose
{
	/// <summary>
	/// Interaction logic for TaskPaneContent.xaml
	/// </summary>
	public partial class TaskPaneContent : UserControl
	{

		Microsoft.Office.Interop.Excel.Application xlApp;
		Workbook xlWorkBook;
		Worksheet xlWorkSheet;


		List<Threads.Thread> preferredThreads => Threads.Threads.List.Where(x => x.MajorBasic < 1 && x.MajorBasic > .249 && x.Class == "2B" && (x.Series == "UNF" || x.Series == "UNC")).ToList();

		public TaskPaneContent()
		{
			InitializeComponent();
			ThreadDataComboBox.ItemsSource = preferredThreads;
		}

		void MyButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			MessageBox.Show("You clicked the button.");



		}

		private void ThreadDataComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			
		}

		
	}
}