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
            string fileName = "";
            string fileFullName = "";
            string sheetName = "";
            FileInfo fileInfo;

            // Se Obtienen el IConfiguración
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();

            // Se extrae los datos de configuración
            filePath = configuration.GetSection("ReportePopInfo:FilePath").Value;
            fileName = configuration.GetSection("ReportePopInfo:FileName").Value;
            fileFullName = $"{filePath}\\{fileName}";
            sheetName = configuration.GetSection("ReportePopInfo:SheetName").Value;

            // Se coloca las conidiciones iniciales
            fileInfo = new FileInfo(fileFullName);

            // Se Inicializa el AppData
            AppData.Inicializar(fileInfo,sheetName);

            // Se coloca los datos del autor
            AppData.AuthorInfo = new AuthorInfo("Renato", "Baudouin", "renato.baudouin@entel.pe", "51998102147");

            // Se coloca los datos de la version
            AppData.AppVersionInfo = new AppVersionInfo("v1.7", new DateTime(2023, 02, 14));

        }
    }
}
