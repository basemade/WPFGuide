using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace WPFGuide
{
    //ListBox 範例
    //WPF p.55

    //ListBoxItem繼承自ContentControl
    //而ListBox繼承自ItemSControl

    //ListBoxItem 就是 ListBox 對應的 ItemContainer
    //每種ItemSControl 都對應有自己的 ItemContainer

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class QTest : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;

            try
            {

                QQMainWindow window = new QQMainWindow(uidoc);
                window.ShowDialog();

                return Result.Succeeded;
            }

            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }

        }
    }
}
