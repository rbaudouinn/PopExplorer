using PopExplorer.Lib.DataAccess;
using PopExplorer.Lib.Models;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Data
{
    static public class AppData
    {
        static public List<Pop> Pops { get; set; }        
        static public FileInfo PopFileInfo { get; set; }
        static public AuthorInfo AuthorInfo { get; set; }
        static public AppVersionInfo AppVersionInfo { get; set; }

        static public void Inicializar(FileInfo popfileInfo,string popSheetName)
        {
            // Definición de variables
            PopDataAccess popDataAccess;
            
            // Condiciones iniciales
            PopFileInfo = popfileInfo;

            // Se obtiene los datos del archivo
            popDataAccess = new PopDataAccess(PopFileInfo, popSheetName);
            Pops = popDataAccess.Pops;

        }
    }
}
