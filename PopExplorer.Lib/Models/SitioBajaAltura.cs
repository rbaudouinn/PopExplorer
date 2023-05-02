using PopExplorer.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Models
{
    public class SitioBajaAltura : IRanNetworkElement
    {

        public string Nombre { get; set; }
        public string SitioAncla { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }        
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string CoberturaPrincipal { get; set; }
        public string TipoDeCoberturaPrincipal { get; set; }
        public string CompromisoRegulatorio { get; set; }
        public string BandaRegulatorio { get; set; }
        public string TipoTorre { get; set; }
        public double AlturaTorre { get; set; }
        public string TipoEstacion { get; set; }
        public double AlturaEdificacion { get; set; }
        public string CoubicadoEn { get; set; }
        public string UbicacionDeEquipo { get; set; }
        public string TipoProyecto { get; set; }
        public string TipoSolucion { get; set; }
        public string Region { get; set; }
        public string Supervisor { get; set; }
        public string Coordinador { get; set; }
        public string ProveedorDeMantenimiento { get; set; }
        public string Consideraciones { get; set; }
        public string SitioContingente { get; set; }

        // Propiedades calculadas
        public string DepartamentoProvinciaDistrito { get => $"{Departamento.ToUpper()} / {Provincia.ToUpper()} / {Distrito.ToUpper()}"; }
        public string ContratistaDepartamentoProvinciaDistrito { get => $"{ProveedorDeMantenimiento} - {DepartamentoProvinciaDistrito}"; }
        public string LatitudLongitud { get => $"{Latitud}, {Longitud}"; }

        public SitioBajaAltura(string nombre, string sitioAncla, string estado, string prioridad, string direccion, 
                               string departamento, string provincia, string distrito, double latitud, double longitud, 
                               string coberturaPrincipal, string tipoDeCoberturaPrincipal, string compromisoRegulatorio, string bandaRegulatorio, string tipoTorre, 
                               double alturaTorre, string tipoEstacion, double alturaEdificacion, string coubicadoEn, string ubicacionDeEquipo, 
                               string tipoProyecto, string tipoSolucion, string region, string supervisor, string coordinador, 
                               string proveedorDeMantenimiento, string consideraciones, string sitioContingente)
        {
            Nombre = nombre;
            SitioAncla = sitioAncla;
            Estado = estado;
            Prioridad = prioridad;
            Direccion = direccion;
            Departamento = departamento;
            Provincia = provincia;
            Distrito = distrito;
            Latitud = latitud;
            Longitud = longitud;
            CoberturaPrincipal = coberturaPrincipal;
            TipoDeCoberturaPrincipal = tipoDeCoberturaPrincipal;
            CompromisoRegulatorio = compromisoRegulatorio;
            BandaRegulatorio = bandaRegulatorio;
            TipoTorre = tipoTorre;
            AlturaTorre = alturaTorre;
            TipoEstacion = tipoEstacion;
            AlturaEdificacion = alturaEdificacion;
            CoubicadoEn = coubicadoEn;
            UbicacionDeEquipo = ubicacionDeEquipo;
            TipoProyecto = tipoProyecto;
            TipoSolucion = tipoSolucion;
            Region = region;
            Supervisor = supervisor;
            Coordinador = coordinador;
            ProveedorDeMantenimiento = proveedorDeMantenimiento;
            Consideraciones = consideraciones;
            SitioContingente = sitioContingente;
        }

        public SitioBajaAltura()
        {
            Nombre = "";
            SitioAncla = "";
            Estado = "";
            Prioridad = "";
            Direccion = "";
            Departamento = "";
            Provincia = "";
            Distrito = "";
            Latitud = double.NaN;
            Longitud = double.NaN;
            CoberturaPrincipal = "";
            TipoDeCoberturaPrincipal = "";
            CompromisoRegulatorio = "";
            BandaRegulatorio = "";
            TipoTorre = "";
            AlturaTorre = double.NaN;
            TipoEstacion = "";
            AlturaEdificacion = double.NaN;
            CoubicadoEn = "";
            UbicacionDeEquipo = "";
            TipoProyecto = "";
            TipoSolucion = "";
            Region = "";
            Supervisor = "";
            Coordinador = "";
            ProveedorDeMantenimiento = "";
            Consideraciones = "";
            SitioContingente = "";
        }

    }
}
