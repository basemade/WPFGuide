using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFGuide
{
    //ps2.此範例分離資料成為獨立cs

    public partial class TTMainWindow : Window
    {
        public UIDocument uidoc;
        public Document doc;

        public TTMainWindow(UIDocument uidocument)
        {

            uidoc = uidocument;
            doc = uidoc.Document;
            InitializeComponent();

            lstBoxEmployee2.DisplayMemberPath = "theName_3";
            lstBoxEmployee2.ItemsSource = TTestData.empList_3;

        }
    }
}
