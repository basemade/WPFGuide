using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


//Addin manager 啟動時，會打開WPF UI
namespace WPFGuide
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class ActiveViewManager : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            try
            {
                View v = doc.ActiveView;
                string vName = v.Name;
                ElementId vId = v.Id;
                ElementId vTemplateId = v.ViewTemplateId;

                /*
                if (vTemplateId.ToString() == "-1")
                {
                   string vTemplate = "No Template";
                }
                else
                {
                   string vTemplate = doc.GetElement(vTemplateId).Name;
                }
                */
                //以上判斷式可簡寫成：
                string vTemplate = vTemplateId.ToString() == "-1" ? "No template" : doc.GetElement(vTemplateId).Name;

                MainWindow window = new MainWindow(uidoc);
                //初始創建 WPF UI 的視窗
                window.label_Name.Content = $"Name：{vName}";
                window.label_Id.Content = $"Id：{vId}";
                window.label_Template.Content = $"View template：{vTemplate}";
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
