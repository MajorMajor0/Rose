
using SolidWorks.Interop.sldworks;
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

namespace RoseWorks
{
	/// <summary>
	/// Interaction logic for TaskPaneContent.xaml
	/// </summary>

	public partial class TaskPane : UserControl
	{

		public TaskPane()
		{
			InitializeComponent();
		}

		void MyButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{






			var Shizzle1 = SW.App.ActiveDoc as ModelDoc2;

			//var Shizzle2 = SW.App.GetDocuments();
			//var Shizzle3 = SW.App.GetDocumentCount();
			//var Shizzle4 = SW.App.GetFirstDocument();

			//SW.App.GetOpenedFileInfo(out string stringer, out int inter);

		}

		private void ThreadDataComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}


	}
}