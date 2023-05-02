﻿using PopExplorer.Lib.DataAccess;
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

        static public AuthorInfo AuthorInfo { get; set; }
        static public AppVersionInfo AppVersionInfo { get; set; }

        static public void Inicializar(FileInfo popFileInfo,string popSheetName, 
                                       FileInfo sitioBajaAlturaFileInfo,
                                       string sitioBajaAlturaSheetName)
        {
            // Definición de variables
            PopDataAccess popDataAccess;
            SitioBajaAlturaDataAccess sitioBajaAlturaDataAccess;
            
            // Condiciones iniciales
            PopFileInfo = popFileInfo;
            SitioBajaAlturaFileInfo = sitioBajaAlturaFileInfo;

            // Se obtiene los datos del archivo
            popDataAccess = new PopDataAccess(PopFileInfo, popSheetName);
            Pops = popDataAccess.Pops;

            sitioBajaAlturaDataAccess = new SitioBajaAlturaDataAccess(sitioBajaAlturaFileInfo, sitioBajaAlturaSheetName);
            SitosBajaAltura = sitioBajaAlturaDataAccess.SitiosBajaAltura;

        }
    }
}
