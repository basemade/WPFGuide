using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFGuide
{
    //ListBox的自動包裝機制
    //兩個簡單的屬性：DisplayMemberPath, ItemsSource
    
    //ps.1 getset 與物件實體化

    //ps2.此範例尚未分離資料成為獨立cs

    public partial class SSMainWindow : Window
    {
        public UIDocument uidoc;
        public Document doc;

        public SSMainWindow(UIDocument uidocument)
        {

            uidoc = uidocument;
            doc = uidoc.Document;
            InitializeComponent();

            List<gagaEmployee2> empList_2 = new List<gagaEmployee2>()
            {
                new gagaEmployee2(){theName_2 = "Timmy", Age_2 = 300},
                new gagaEmployee2(){theName_2 = "Tommy", Age_2 = 260},
                new gagaEmployee2(){theName_2 = "Guomy", Age_2 = 240},
                new gagaEmployee2(){theName_2 = "Kammy", Age_2 = 340},
                new gagaEmployee2(){theName_2 = "Apey", Age_2 = 300},
                new gagaEmployee2(){theName_2 = "Ronny", Age_2 = 280}
            };

            lstBoxEmployee2.DisplayMemberPath = "theName_2";
            lstBoxEmployee2.SelectedValuePath = "Age_2";
            lstBoxEmployee2.ItemsSource = empList_2;
        }
        

        public class gagaEmployee2
        {
            public string theName_2 { get; set; }
            //這裡一定要加上get set，不然沒有值
            public int Age_2 { get; set; }
        }
    }
}
