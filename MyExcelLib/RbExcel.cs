using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExcelLib
{
    static public class RbExcel
    {
        // RbExcel
        // 
        // Se debe crear el objeto sLDocument de a suguiente forma
        //  sLDocument = new SLDocument(FileInfo.FullName,SheetName);

        static public int ContarFilas(SLDocument sLDocument, int row, int column)
        {
            // Definición de variables
            int salida = -1;
            string auxiliar="";
            int i;

            // Se recorre las filas
            i = 0;
            do
            {
                auxiliar = sLDocument.GetCellValueAsString(row + i, column);
                i++;
            } while (!auxiliar.Trim().Equals(""));

            salida = i-1;
            return salida;
        }


        static public int EncontaraFila(SLDocument sLDocument, string fila, int column, int limit)
        {
            // Definición de variables
            int salida = -1;
            int i;
            string auxiliar;

            // Se encuentra la columna
            for (i = 0; i <= limit - 1; i++)
            {
                auxiliar = sLDocument.GetCellValueAsString(i + 1,column);

                if (auxiliar.Equals(fila))
                {
                    break;
                }
            }

            // Fin
            salida = i + 1;
            return salida;
        }


        static public int EncontaraColumna(SLDocument sLDocument, string columna, int row, int limit)
        {
            // Definición de variables
            int salida = -1;
            int i;
            string auxiliar;
            object rangeObject;
            Range range;
            Sheet sheet;

            // Se encuentra la columna
            for (i = 0; i <= limit-1; i++)
            {
               auxiliar = sLDocument.GetCellValueAsString(row,i+1);

                if (auxiliar.Equals(columna))
                { 
                    break;
                }
            }

            // Fin
            salida = i + 1;
            return salida;
        }
    }
}
