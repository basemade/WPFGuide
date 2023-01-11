using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;

namespace WPFGuide
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //public UIDocument gaga { get; }
        //後面加get，定義gaga為只能讀的成員
        //https://blog.csdn.net/alzzw/article/details/112859568
        public UIDocument uidoc;
        public Document doc;

        public MainWindow(UIDocument uidocument)
        {
            //gaga = uidocument;
            uidoc = uidocument;
            doc = uidoc.Document;
            InitializeComponent();
            Title = "Mini active view manager";
        }

        private void SetViewName(object sender, RoutedEventArgs e)
        {
            using (Transaction t = new Transaction(doc, "set view name gaga"))
            {
                t.Start();
                doc.ActiveView.Name = textgaga.Text;
                //在Textbox輸入的文字，指定成為ActiveView.Name
                t.Commit();
            }
        }

        private void PrintView(object sender, RoutedEventArgs e)
        {
            using (Transaction t = new Transaction(doc, "print view gaga"))
            {
                t.Start();
                doc.ActiveView.Print();
                t.Commit();
            }
        }
    }
}
