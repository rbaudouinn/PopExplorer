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
        static public FileInfo FileInfo { get; set; }
        static public AuthorInfo AuthorInfo { get; set; }
        static public AppVersionInfo AppVersionInfo { get; set; }

        static public void Inicializar(FileInfo fileInfo,string sheetName)
        {
            // Definición de variables
            PopDataAccess popDataAccess;
            
            // Condiciones iniciales
            FileInfo = fileInfo;

            // Se obtiene los datos del archivo
            popDataAccess = new PopDataAccess(FileInfo, sheetName);
            Pops = popDataAccess.Pops;

        }
    }
}
