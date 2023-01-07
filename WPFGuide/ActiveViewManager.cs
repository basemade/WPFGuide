using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


//Addin manager �ҰʮɡA�|���}WPF UI
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
                //�H�W�P�_���i²�g���G
                string vTemplate = vTemplateId.ToString() == "-1" ? "No template" : doc.GetElement(vTemplateId).Name;

                MainWindow window = new MainWindow(uidoc);
                //��l�Ы� WPF UI ������
                window.label_Name.Content = $"Name�G{vName}";
                window.label_Id.Content = $"Id�G{vId}";
                window.label_Template.Content = $"View template�G{vTemplate}";
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
