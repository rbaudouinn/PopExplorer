using PopExplorer.Lib.DataAccess;
using PopExplorer.Lib.Interfaces;
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
        
        static public List<SitioBajaAltura> SitosBajaAltura { get; set; }
        static public FileInfo SitioBajaAlturaFileInfo { get; set; }

        static public List<SitioBajaAltura> MicroCeldas { get; set; }
        static public FileInfo MicroCeldaFileInfo { get; set; }

        static public List<SmallCell> SmallCells { get; set; }
        static public FileInfo SmallCellFillInfo { get; set; }


        static public List<IRanNetworkElement> RanNetworkElements { get; set; }

        static public AuthorInfo AuthorInfo { get; set; }
        static public AppVersionInfo AppVersionInfo { get; set; }

        static public void Inicializar(FileInfo popFileInfo,string popSheetName, 
                                       FileInfo sitioBajaAlturaFileInfo, string sitioBajaAlturaSheetName,
                                       FileInfo microCeldaFileInfo, string microCeldaSheetName,
                                       FileInfo smallCellFileInfo, string smallCellSheetName)
        {
            // Definición de variables
            PopDataAccess popDataAccess;
            SitioBajaAlturaDataAccess sitioBajaAlturaDataAccess;
            SitioBajaAlturaDataAccess microCeldaDataAccess;
            SmallCellDataAccess smallCellDataAccess;

            // Condiciones iniciales
            PopFileInfo = popFileInfo;
            SitioBajaAlturaFileInfo = sitioBajaAlturaFileInfo;
            MicroCeldaFileInfo = microCeldaFileInfo;

            // Se obtiene los datos de los archivos
            popDataAccess = new PopDataAccess(PopFileInfo, popSheetName,"Pop");
            Pops = popDataAccess.Pops;

            sitioBajaAlturaDataAccess = new SitioBajaAlturaDataAccess(sitioBajaAlturaFileInfo, sitioBajaAlturaSheetName, "Sitio Baja Altura");
            SitosBajaAltura = sitioBajaAlturaDataAccess.SitiosBajaAltura;

            microCeldaDataAccess = new SitioBajaAlturaDataAccess(microCeldaFileInfo, microCeldaSheetName, "Micro Celda");
            MicroCeldas = microCeldaDataAccess.SitiosBajaAltura;

            smallCellDataAccess = new SmallCellDataAccess(smallCellFileInfo, smallCellSheetName, "Small Cell");
            SmallCells = smallCellDataAccess.SmallCells;


            // Se obtiene la lista RanNetworkElements
            ObtenerListaRanNetworkElements();
        }

        static private void ObtenerListaRanNetworkElements()
        {
            // Condiciones iniciales
            RanNetworkElements = new List<IRanNetworkElement>();

            // Se llena la lista con información de Pop
            foreach (var item in Pops)
            {
                RanNetworkElements.Add(item);
            }

            // Se llena la lista con información de Sitios Baja Altura
            foreach (var item in SitosBajaAltura)
            {
                RanNetworkElements.Add(item);
            }

            // Se llena la lista con información de Micro Celdas
            foreach (var item in MicroCeldas)
            {
                RanNetworkElements.Add(item);
            }

            // Se llena la lista con informaciön de Small Cells
            foreach (var item in SmallCells)
            {
                RanNetworkElements.Add(item);
            }
        }
    }
}
