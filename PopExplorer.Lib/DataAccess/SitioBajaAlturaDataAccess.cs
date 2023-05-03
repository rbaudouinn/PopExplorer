using MyExcelLib;
using PopExplorer.Lib.Models;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.DataAccess
{
    public class SitioBajaAlturaDataAccess
    {
        public List<SitioBajaAltura> SitiosBajaAltura { get; internal set; }
        public FileInfo FileInfo { get; set; }
        public string SheetName { get; set; }
        public string Log { get; set; }

        public SitioBajaAlturaDataAccess(FileInfo fileInfo, string sheetName)
        {
            FileInfo = fileInfo;
            SheetName = sheetName;
            SitiosBajaAltura = new List<SitioBajaAltura>();
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            string mensaje = "";

            if (FileInfo.Exists)
            {
                ObtenerLista();
            }
            else
            {
                mensaje = "El archivo no existe";
                EscribirLog(mensaje);
            }
        }

                

        private void ObtenerLista()
        {
            // Definición de variables
            SLDocument sLDocument;
            int numberOfRows;
            int i;
            string auxiliar;
            bool flagNumberParse;
            SitioBajaAltura sitioBajaAltura;

            string nombre; string sitioAncla; string estado; string prioridad; string direccion;
            string departamento; string provincia; string distrito; double latitud; double longitud;
            string coberturaPrincipal; string tipoCoberturaPrincipal; string compromisoRegulatorio; string bandaRegulatorio; string tipoTorre;
            double alturaTorre; string tipoEstacion; double alturaEdificacion; string coubicadoEn; string ubicacionDeEquipo;
            string tipoProyecto; string tipoSolucion; string region; string supervisor; string coordinador;
            string proveedorDeMantenimiento; string consideraciones; string sitioContingente;

            // Se abre el archivo excel.
            sLDocument = new SLDocument(FileInfo.FullName, SheetName);

            // Se obtiene el número de filas
            numberOfRows = RbExcel.ContarFilas(sLDocument, 2, 2);

            // Se recorre el archivo excel
            SitiosBajaAltura = new List<SitioBajaAltura>();
            for (i = 0; i <= numberOfRows - 1; i++)
            {
                nombre = sLDocument.GetCellValueAsString(i + 2, 2);
                sitioAncla = sLDocument.GetCellValueAsString(i + 2, 3);
                estado = sLDocument.GetCellValueAsString(i + 2, 4);
                prioridad = sLDocument.GetCellValueAsString(i + 2, 5);
                direccion = sLDocument.GetCellValueAsString(i + 2, 8);
                departamento = sLDocument.GetCellValueAsString(i + 2, 9);
                provincia = sLDocument.GetCellValueAsString(i + 2, 10);
                distrito = sLDocument.GetCellValueAsString(i + 2, 11);

                // Latitud
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 12);
                flagNumberParse = double.TryParse(auxiliar, out latitud);
                // Longitud
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 13);
                flagNumberParse = double.TryParse(auxiliar, out longitud);

                coberturaPrincipal = sLDocument.GetCellValueAsString(i + 2, 14);
                tipoCoberturaPrincipal = sLDocument.GetCellValueAsString(i + 2, 15);
                compromisoRegulatorio = sLDocument.GetCellValueAsString(i + 2, 16);
                bandaRegulatorio = sLDocument.GetCellValueAsString(i + 2, 17);
                tipoTorre = sLDocument.GetCellValueAsString(i + 2, 18);

                // Altura torre
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 19);
                flagNumberParse = double.TryParse(auxiliar, out alturaTorre);
                if (flagNumberParse == false)
                { alturaTorre = double.NaN; }

                tipoEstacion = sLDocument.GetCellValueAsString(i + 2, 20);

                // Altura Edificacion
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 21);
                flagNumberParse = double.TryParse(auxiliar, out alturaEdificacion);
                if (flagNumberParse == false)
                { alturaEdificacion = double.NaN; }

                coubicadoEn = sLDocument.GetCellValueAsString(i + 2, 23);
                ubicacionDeEquipo = sLDocument.GetCellValueAsString(i + 2, 25);
                tipoProyecto = sLDocument.GetCellValueAsString(i + 2, 26);
                tipoSolucion = sLDocument.GetCellValueAsString(i + 2, 27);
                region = sLDocument.GetCellValueAsString(i + 2, 28);
                supervisor = sLDocument.GetCellValueAsString(i + 2, 29);
                coordinador = sLDocument.GetCellValueAsString(i + 2, 30);
                proveedorDeMantenimiento = sLDocument.GetCellValueAsString(i + 2, 31);
                consideraciones = sLDocument.GetCellValueAsString(i + 2, 36);
                sitioContingente = sLDocument.GetCellValueAsString(i + 2, 37);

                sitioBajaAltura = new SitioBajaAltura(nombre, sitioAncla, estado, prioridad, direccion,
                                                      departamento, provincia, distrito, latitud, longitud,
                                                      coberturaPrincipal, tipoCoberturaPrincipal, compromisoRegulatorio, bandaRegulatorio, tipoTorre,
                                                      alturaTorre, tipoEstacion, alturaEdificacion, coubicadoEn, ubicacionDeEquipo,
                                                      tipoProyecto, tipoSolucion, region, supervisor, coordinador,
                                                      proveedorDeMantenimiento, consideraciones, sitioContingente);
                SitiosBajaAltura.Add(sitioBajaAltura);
            }

        }

        private void EscribirLog(string mensaje)
        {
            Log = Log + Environment.NewLine + mensaje;
        }
    }
}
