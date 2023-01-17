using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFGuide
{
    //此範例說明ListBoxItem是ListBox對應的ItemContainer
    //WPF p.55

    public partial class QQMainWindow : Window
    {
        public UIDocument uidoc;
        public Document doc;
        StringBuilder sb;

        public QQMainWindow(UIDocument uidocument)
        {
            uidoc = uidocument;
            doc = uidoc.Document;
            InitializeComponent();
            sb = new StringBuilder();
        }

        private void buttonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            //sender 是一個 object type 的實作
            //Button btn = sender as Button 這句的意思是：
            //實作一個名叫btn的 Button 類別，他所乘載的已知屬性源自名為sender的object
            //概念：若子代(button)繼承於父代(object)，那麼可以用as進行轉型

            DependencyObject level1 = VisualTreeHelper.GetParent(btn);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);

            sb.AppendLine($"【{btn.ToString()}】's parent is：【{level1.ToString()}】");
            sb.AppendLine();
            sb.AppendLine($"【{level1.ToString()}】's parent is：【{level2.ToString()}】");
            sb.AppendLine();
            sb.AppendLine($"【{level2.ToString()}】's parent is：【{level3.ToString()}】");

            MessageBox.Show(sb.ToString());
            sb.Clear();
        }
    }
}
