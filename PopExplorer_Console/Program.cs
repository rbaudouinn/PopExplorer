using MyExcelLib;
using PopExplorer.Lib.DataAccess;
using SpreadsheetLight;

namespace PopExplorer_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice;
            FileInfo fileInfo;

            fileInfo = new FileInfo(@"D:\Datos de Usuario\rbaudouinn\Documents\Reportes PortalOymSitios\Reporte_Sitio_POP.xlsx");
            SLDocument sLDocument = new SLDocument(fileInfo.FullName);

            indice = RbExcel.EncontaraColumna(sLDocument,"Prioridad",1,100);
            indice = RbExcel.ContarFilas(sLDocument, 2, 2);

            PopDataAccess popDataAccess;

            //popDataAccess = new PopDataAccess(fileInfo, "Site POP",networkElementType.);

        }
    }
}