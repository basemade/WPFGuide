using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace WPFGuide
{
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
