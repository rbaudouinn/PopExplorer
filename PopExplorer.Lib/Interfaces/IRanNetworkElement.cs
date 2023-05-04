using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Interfaces
{
    public interface IRanNetworkElement
    {
        public string NetWorkElementType { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }        
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
