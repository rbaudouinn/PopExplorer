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
    public class PopDataAccess
    {
        public string NetworkElementType { get; set; }
        public List<Pop> Pops { get; internal set; }
        public FileInfo FileInfo { get; set; }
        public string SheetName { get; set; }
        public string Log { get; set; }        

        public PopDataAccess(FileInfo fileInfo, string sheetName, string networkElementType)
        {
            NetworkElementType = networkElementType;
            FileInfo = fileInfo;
            SheetName = sheetName;
            Pops = new List<Pop>();
            ObtenerDatos();
            
        }

        void ObtenerDatos()
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

        void ObtenerLista()
        {
            // Definición de variables
            SLDocument sLDocument;
            int numberOfRows;
            int i;
            string auxiliar;
            bool flagNumberParse;
            Pop pop;

            string nombre; string estado; string prioridad; string tipoClienteFija; string sitioBafi ; string clienteAltoValor; string direccion; 
            string departamento; string provincia; string distrito; string zona; double latitud; double longitud; 
            string tipoTorre; double alturaTorre; string tipoEstacion; double alturaEdificacion; string coubicadorFinal; 
            string nombreSitioCoubicador; string operadorCoubicado; string nombreSitioCoubicante; string codigoCoubicador; 
            string ubicacionEquipos; string agregador; string preAgregador; string proveedorDeMantenimiento; string accesoLibre24h; 
            int serviciosGul; int serviciosBafi; string region; string supervisor; string coordinador;

            // Se abre el archivo excel.
            sLDocument = new SLDocument(FileInfo.FullName,SheetName);

            // Se obtiene el número de filas
            numberOfRows = RbExcel.ContarFilas(sLDocument, 2, 2);

            // Se recorre el archivo excel
            Pops = new List<Pop>();
            for (i = 0; i <= numberOfRows - 1; i++)
            {
                nombre = sLDocument.GetCellValueAsString(i + 2, 2);
                estado = sLDocument.GetCellValueAsString(i + 2, 3);
                prioridad = sLDocument.GetCellValueAsString(i + 2, 4);
                tipoClienteFija = sLDocument.GetCellValueAsString(i + 2, 6);
                sitioBafi = sLDocument.GetCellValueAsString(i + 2, 75);
                clienteAltoValor = sLDocument.GetCellValueAsString(i + 2, 7);
                direccion = sLDocument.GetCellValueAsString(i + 2, 8);
                departamento = sLDocument.GetCellValueAsString(i + 2, 11);
                provincia = sLDocument.GetCellValueAsString(i + 2, 12);
                distrito = sLDocument.GetCellValueAsString(i + 2, 13);
                zona = sLDocument.GetCellValueAsString(i + 2, 14);
                
                // Latitud
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 16);
                flagNumberParse = double.TryParse(auxiliar, out latitud);
                // Longitud
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 17);
                flagNumberParse = double.TryParse(auxiliar, out longitud);

                tipoTorre = sLDocument.GetCellValueAsString(i + 2, 25);

                // Altura Torre
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 26);
                flagNumberParse = double.TryParse(auxiliar, out alturaTorre);

                tipoEstacion = sLDocument.GetCellValueAsString(i + 2, 28);

                // alturaEdificacion
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 26);
                flagNumberParse = double.TryParse(auxiliar, out alturaEdificacion);

                coubicadorFinal = sLDocument.GetCellValueAsString(i + 2, 41);
                nombreSitioCoubicador = sLDocument.GetCellValueAsString(i + 2, 42);
                operadorCoubicado = sLDocument.GetCellValueAsString(i + 2, 43);
                nombreSitioCoubicante = sLDocument.GetCellValueAsString(i + 2, 44);
                codigoCoubicador = sLDocument.GetCellValueAsString(i + 2, 45);
                ubicacionEquipos = sLDocument.GetCellValueAsString(i + 2, 46);
                agregador = sLDocument.GetCellValueAsString(i + 2, 52);
                preAgregador = sLDocument.GetCellValueAsString(i + 2, 53);
                proveedorDeMantenimiento = sLDocument.GetCellValueAsString(i + 2, 62);
                accesoLibre24h = sLDocument.GetCellValueAsString(i + 2, 64);

                // serviciosGul
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 92);
                flagNumberParse = int.TryParse(auxiliar, out serviciosGul);
                if (flagNumberParse == false)
                {
                    serviciosGul = 0;
                }

                // Bafi
                auxiliar = sLDocument.GetCellValueAsString(i + 2, 94);
                flagNumberParse = int.TryParse(auxiliar, out serviciosBafi);
                if (flagNumberParse == false)
                {
                    serviciosBafi = 0;
                }

                region = sLDocument.GetCellValueAsString(i + 2, 97);
                supervisor = sLDocument.GetCellValueAsString(i + 2, 98);
                coordinador = sLDocument.GetCellValueAsString(i + 2, 99);

                pop = new Pop(NetworkElementType, nombre, estado, prioridad, tipoClienteFija, sitioBafi, clienteAltoValor, direccion, departamento, provincia, distrito, zona,
                              latitud, longitud, tipoTorre, alturaTorre, tipoEstacion, alturaEdificacion, coubicadorFinal, nombreSitioCoubicador,
                              operadorCoubicado, nombreSitioCoubicante, codigoCoubicador, ubicacionEquipos, agregador, preAgregador, proveedorDeMantenimiento,
                              accesoLibre24h, serviciosGul, serviciosBafi, region, supervisor, coordinador);
                Pops.Add(pop);
            }
        }

        private void EscribirLog(string mensaje)
        {
            Log = Log + Environment.NewLine + mensaje;
        }
    }

    
}
