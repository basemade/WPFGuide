using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFGuide
{
    //PPMainWindow.xaml.cs，從字母P開始排序，進行測試
    //往後測試請以字母P的檔案去clone
    public partial class PPMainWindow : Window
    {
        public UIDocument uidoc;
        public Document doc;
        StringBuilder sb;

        public PPMainWindow(UIDocument uidocument)
        {
            uidoc = uidocument;
            doc = uidoc.Document;
            InitializeComponent();
            sb = new StringBuilder();
        }

        private void buttonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show(btn.GetType().ToString());

        }
    }
}
