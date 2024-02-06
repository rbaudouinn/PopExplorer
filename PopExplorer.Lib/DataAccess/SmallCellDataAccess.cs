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
    public class SmallCellDataAccess
    {
        public string NetworkElementType { get; set; }
        public List<SmallCell> SmallCells { get; internal set; }
        public FileInfo FileInfo { get; set; }
        public string SheetName { get; set; }
        public string Log { get; set; }

        public SmallCellDataAccess(FileInfo fileInfo, string sheetName, string networkElementType)
        {
            FileInfo = fileInfo;
            SheetName = sheetName;
            NetworkElementType = networkElementType;
            SmallCells = new List<SmallCell>();
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
            int columNIndex;
            string auxiliar;
            bool flagNumberParse;
            SmallCell smallCell;

            string networkElementType; string nombre; string estado; string prioridad; string direccion; string departamento; string provincia; string distrito; double latitud; double longitud;
            string numeroImsi; string numeroDeGestion; string ipGestion; string tipoDeSite; string razonSocial; string region; string supervisor; string coordinador; DateOnly? fechaOnAir;
            string siteServidor; string pisoDeAntenaDonadora; string tipoDeTransmision; string tipoPredio; string nombreDeContacto; string numeroDeContacto; string consideracionesDeAcceso;
            string proveedorDeMantenimiento;

            // Se abre el archivo excel.
            sLDocument = new SLDocument(FileInfo.FullName, SheetName);

            // Se obtiene el número de filas
            numberOfRows = RbExcel.ContarFilas(sLDocument, 2, 2);

            // Se recorre el archivo excel
            SmallCells = new List<SmallCell>();
            prioridad = "";
            for (i = 0; i <= numberOfRows - 1; i++)
            {
                nombre = sLDocument.GetCellValueAsString(i + 2, 2);
                estado = sLDocument.GetCellValueAsString(i + 2, 3);
                direccion = sLDocument.GetCellValueAsString(i + 2, 10);
                departamento = sLDocument.GetCellValueAsString(i + 2, 11);
                provincia = sLDocument.GetCellValueAsString(i + 2, 12);
                distrito = sLDocument.GetCellValueAsString(i + 2, 13);

                // Latitud
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 14);
                flagNumberParse = double.TryParse(auxiliar, out latitud);
                // Longitud
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 15);
                flagNumberParse = double.TryParse(auxiliar, out longitud);

                numeroImsi = sLDocument.GetCellValueAsString(i + 2, 4);
                numeroDeGestion = sLDocument.GetCellValueAsString(i + 2, 5);
                ipGestion = sLDocument.GetCellValueAsString(i + 2, 6);
                tipoDeSite = sLDocument.GetCellValueAsString(i + 2, 8);
                razonSocial = sLDocument.GetCellValueAsString(i + 2, 9);
                region = sLDocument.GetCellValueAsString(i + 2, 16);
                supervisor = sLDocument.GetCellValueAsString(i + 2, 17);
                coordinador = sLDocument.GetCellValueAsString(i + 2, 18);

                siteServidor = sLDocument.GetCellValueAsString(i + 2, 21);
                pisoDeAntenaDonadora = sLDocument.GetCellValueAsString(i + 2, 22);
                tipoDeTransmision = sLDocument.GetCellValueAsString(i + 2, 23);
                tipoPredio = sLDocument.GetCellValueAsString(i + 2, 24);
                nombreDeContacto = sLDocument.GetCellValueAsString(i + 2, 25);
                numeroDeContacto = sLDocument.GetCellValueAsString(i + 2, 26);
                consideracionesDeAcceso = sLDocument.GetCellValueAsString(i + 2, 27);
                proveedorDeMantenimiento = sLDocument.GetCellValueAsString(i + 2, 28);

                // Fechas
                columNIndex = RbExcel.EncontaraColumna(sLDocument, "Fecha On Air", 1, 100);
                auxiliar = sLDocument.GetCellValueAsString(i + 2, columNIndex);
                fechaOnAir = GetDateFromText(auxiliar);

                smallCell = new SmallCell(NetworkElementType, nombre, estado, prioridad, direccion, departamento, provincia, distrito, latitud, longitud,
                                          numeroImsi, numeroDeGestion, ipGestion, tipoDeSite, razonSocial, region, supervisor, coordinador, fechaOnAir,
                                          siteServidor, pisoDeAntenaDonadora, tipoDeTransmision, tipoPredio, nombreDeContacto, numeroDeContacto, consideracionesDeAcceso,
                                          proveedorDeMantenimiento);
                SmallCells.Add(smallCell);
            }
        }

        private DateOnly? GetDateFromText(string text)
        {
            DateOnly? output;
            DateOnly dateOnly;
            bool flag;

            flag = DateOnly.TryParseExact(text, "dd/MM/yyyy", out dateOnly);

            if (flag == true)
            {
                output = (DateOnly?)dateOnly;
            }
            else
            {
                output = null;
            }

            return output;
        }


        private void EscribirLog(string mensaje)
        {
            Log = Log + Environment.NewLine + mensaje;
        }

    }
}
