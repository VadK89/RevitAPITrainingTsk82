using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingTsk82
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        //Задание 8.2 Экспорт NWC
        //Экспортируйте модель из файлов упражнений в формат NWC с помощью приложения.
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            NavisworksExportOptions nwcExportOptions = new NavisworksExportOptions();

            //метод экспорта в nwc
            //using (var ts = new Transaction(doc, "export nwc"))

            //{
                //ts.Start();
                doc.Export(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExportNWC", nwcExportOptions);
                //ts.Commit();
            //}

            TaskDialog.Show("Мессадж", "Экспорт завершен. Ищите файл на рабочем столе");
            return Result.Succeeded;
        }
    }
}
