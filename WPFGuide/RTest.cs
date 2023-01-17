using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace WPFGuide
{
    //釐清Content control vs ItemS control
    //p.52

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class RTest : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;

            try
            {

                RRMainWindow window = new RRMainWindow(uidoc);
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
