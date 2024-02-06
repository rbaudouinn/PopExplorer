using PopExplorer.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Models
{
    public class SmallCell : IRanNetworkElement
    {      
        public string NetworkElementType { get ; set ; }
        public string Nombre { get ; set ; }
        public string Estado { get ; set ; }
        public string Prioridad { get ; set ; }
        public string Direccion { get ; set ; }
        public string Departamento { get ; set ; }
        public string Provincia { get ; set ; }
        public string Distrito { get ; set ; }
        public double Latitud { get ; set ; }
        public double Longitud { get ; set ; }
        public string NumeroImsi { get; set; }
        public string NumeroDeGestion { get; set; }
        public string IpGestion { get; set; }
        public string TipoDeSite { get; set; }
        public string RazonSocial { get; set; }
        public string Region { get; set; }
        public string Supervisor { get; set; }
        public string Coordinador { get; set; }
        public DateOnly? FechaOnAir { get; set; }
        public string SiteServidor { get; set; }
        public string PisoDeAntenaDonadora { get; set; }
        public string TipoDeTransmision { get; set; }
        public string TipoPredio { get; set; }
        public string NombreDeContacto { get; set; }
        public string NumeroDeContacto { get; set; }
        public string ConsideracionesDeAcceso { get; set; }
        public string ProveedorDeMantenimiento { get; set; }

        public SmallCell(string networkElementType, string nombre, string estado, string prioridad, string direccion, string departamento, string provincia, string distrito, double latitud, double longitud, 
                         string numeroImsi, string numeroDeGestion, string ipGestion, string tipoDeSite, string razonSocial, string region, string supervisor, string coordinador, DateOnly? fechaOnAir, 
                         string siteServidor, string pisoDeAntenaDonadora, string tipoDeTransmision, string tipoPredio, string nombreDeContacto, string numeroDeContacto, string consideracionesDeAcceso, 
                         string proveedorDeMantenimiento)
        {
            NetworkElementType = networkElementType;
            Nombre = nombre;
            Estado = estado;
            Prioridad = prioridad;
            Direccion = direccion;
            Departamento = departamento;
            Provincia = provincia;
            Distrito = distrito;
            Latitud = latitud;
            Longitud = longitud;
            NumeroImsi = numeroImsi;
            NumeroDeGestion = numeroDeGestion;
            IpGestion = ipGestion;
            TipoDeSite = tipoDeSite;
            RazonSocial = razonSocial;
            Region = region;
            Supervisor = supervisor;
            Coordinador = coordinador;
            FechaOnAir = fechaOnAir;
            SiteServidor = siteServidor;
            PisoDeAntenaDonadora = pisoDeAntenaDonadora;
            TipoDeTransmision = tipoDeTransmision;
            TipoPredio = tipoPredio;
            NombreDeContacto = nombreDeContacto;
            NumeroDeContacto = numeroDeContacto;
            ConsideracionesDeAcceso = consideracionesDeAcceso;
            ProveedorDeMantenimiento = proveedorDeMantenimiento;
        }

    }
}
