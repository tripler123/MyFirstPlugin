using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace MyFirstPlugin
{
    public class CmdMyFirstPlugin : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Title", "Mensaje de prueba");

            return Result.Succeeded;
        }
    }
}
