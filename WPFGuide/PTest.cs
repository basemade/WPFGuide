using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace WPFGuide
{
    //PTest，從字母P開始排序，進行測試
    //往後測試請以字母P的檔案去clone

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class PTest : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;

            try
            {

                PPMainWindow window = new PPMainWindow(uidoc);
                //初始創建 WPF UI 的視窗
                window.ShowDialog();
                //需要這行才會顯示

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
