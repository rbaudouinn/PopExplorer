using Microsoft.Extensions.Configuration;
using PopExplorer.Lib.Data;
using PopExplorer.Lib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PopExplorer_Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Definición de variables
            string filePath = "";

            string popFileName = "";
            string popFileFullName = "";
            string popSheetName = "";
            FileInfo popFileInfo;

            string sitioBajaAlturaFileName = "";
            string sitioBajaAlturaFileFullName = "";
            string sitioBajaAlturaSheetName = "";
            FileInfo sitioBajaAlturaFileInfo;


            // Se Obtienen el IConfiguración
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();

            // Se extrae los datos de configuración de Reporte_Sitio_POP.xlsx
            filePath = configuration.GetSection("ReportePopInfo:FilePath").Value;

            popFileName = configuration.GetSection("ReportePopInfo:Pop:FileName").Value;
            popFileFullName = $"{filePath}\\{popFileName}";
            popSheetName = configuration.GetSection("ReportePopInfo:Pop:SheetName").Value;

            sitioBajaAlturaFileName = configuration.GetSection("ReportePopInfo:BajaAltura:FileName").Value;
            sitioBajaAlturaFileFullName = $"{filePath}\\{sitioBajaAlturaFileName}";
            sitioBajaAlturaSheetName = configuration.GetSection("ReportePopInfo:BajaAltura:SheetName").Value;

            // Se coloca las conidiciones iniciales
            popFileInfo = new FileInfo(popFileFullName);
            sitioBajaAlturaFileInfo = new FileInfo(sitioBajaAlturaFileFullName);

            // Se Inicializa el AppData
            AppData.Inicializar(popFileInfo,popSheetName, sitioBajaAlturaFileInfo, sitioBajaAlturaSheetName);

            // Se coloca los datos del autor
            AppData.AuthorInfo = new AuthorInfo("Renato", "Baudouin", "renato.baudouin@entel.pe", "+51998102147");

            // Se coloca los datos de la version
            AppData.AppVersionInfo = new AppVersionInfo("v1.8", new DateTime(2023, 05, 02));

        }
    }
}
