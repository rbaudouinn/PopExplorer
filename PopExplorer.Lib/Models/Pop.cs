using PopExplorer.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Models
{
    public class Pop : IRanNetworkElement
    {
        public string NetworkElementType { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string TipoClienteFija { get; set; }
        public string SitioBafi { get; set; }
        public string ClienteAltoValor { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Zona { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string TipoTorre { get; set; }
        public double AlturaTorre { get; set; }
        public string TipoEstacion { get; set; }
        public double AlturaEdificacion { get; set; }
        public string CoubicadorFinal { get; set; }
        public string NombreSitioCoubicador { get; set; }
        public string OperadorCoubicado { get; set; }
        public string NombreSitioCoubicante { get; set; }
        public string CodigoCoubicador { get; set; }
        public string UbicacionEquipos { get; set; }
        public string Agregador { get; set; }
        public string PreAgregador { get; set; }
        public string ProveedorDeMantenimiento { get; set; }
        public string AccesoLibre24h { get; set; }
        public int ServiciosGul { get; set; }
        public int ServiciosBafi { get; set; }
        public string Region { get; set; }
        public string Supervisor { get; set; }
        public string Coordinador { get; set; }
        public DateOnly? FechaOnAir { get; set; }

        // Propiedades calculadas
        public string Servicios { get => ObtenerServicios();}
        public string PrioridadServicios { get => ObtenerPrioridadServicios(); }
        public string PopPrioridadServicios { get => ObtenerPopPrioridadServicios(); }
        public string DepartamentoProvinciaDistrito { get => $"{Departamento.ToUpper()} / {Provincia.ToUpper()} / {Distrito.ToUpper()}"; }
        public string ContratistaDepartamentoProvinciaDistrito { get => $"{ProveedorDeMantenimiento} - {DepartamentoProvinciaDistrito}"; }
        public string LatitudLongitud { get => $"{Latitud}, {Longitud}"; }


        public Pop(string networkElementType, string nombre, string estado, string prioridad, string tipoClienteFija, string sitioBafi, string clienteAltoValor, string direccion, string departamento, string provincia, string distrito, string zona,
                   double latitud, double longitud, string tipoTorre, double alturaTorre, string tipoEstacion, double alturaEdificacion, string coubicadorFinal, string nombreSitioCoubicador,
                   string operadorCoubicado, string nombreSitioCoubicante, string codigoCoubicador, string ubicacionEquipos, string agregador, string preAgregador, string proveedorDeMantenimiento,
                   string accesoLibre24h, int serviciosGul, int serviciosBafi, string region, string supervisor, string coordinador, DateOnly? fechaOnAir)
        {
            NetworkElementType = networkElementType;
            Nombre = nombre;
            Estado = estado;
            Prioridad = prioridad;
            TipoClienteFija = tipoClienteFija;
            SitioBafi = sitioBafi;
            ClienteAltoValor = clienteAltoValor;
            Direccion = direccion;
            Departamento = departamento;
            Provincia = provincia;
            Distrito = distrito;
            Zona = zona;
            Latitud = latitud;
            Longitud = longitud;
            TipoTorre = tipoTorre;
            AlturaTorre = alturaTorre;
            TipoEstacion = tipoEstacion;
            AlturaEdificacion = alturaEdificacion;
            CoubicadorFinal = coubicadorFinal;
            NombreSitioCoubicador = nombreSitioCoubicador;
            OperadorCoubicado = operadorCoubicado;
            NombreSitioCoubicante = nombreSitioCoubicante;
            CodigoCoubicador = codigoCoubicador;
            UbicacionEquipos = ubicacionEquipos;
            Agregador = agregador;
            PreAgregador = preAgregador;
            ProveedorDeMantenimiento = proveedorDeMantenimiento;
            AccesoLibre24h = accesoLibre24h;
            ServiciosGul = serviciosGul;
            ServiciosBafi = serviciosBafi;
            Region = region;
            Supervisor = supervisor;
            Coordinador = coordinador;
            FechaOnAir = fechaOnAir;
        }

        public Pop()
        {
            NetworkElementType = "";
            Nombre = "";
            Estado = "";
            Prioridad = "";
            TipoClienteFija = "";
            SitioBafi = "";
            ClienteAltoValor = "";
            Direccion = "";
            Departamento = "";
            Provincia = "";
            Distrito = "";
            Zona = "";
            Latitud = -1;
            Longitud = -1;
            TipoTorre = "";
            AlturaTorre = 0;
            TipoEstacion = "";
            AlturaEdificacion = 0;
            CoubicadorFinal = "";
            NombreSitioCoubicador = "";
            OperadorCoubicado = "";
            NombreSitioCoubicante = "";
            CodigoCoubicador = "";
            UbicacionEquipos = "";
            Agregador = "";
            PreAgregador = "";
            ProveedorDeMantenimiento = "";
            AccesoLibre24h = "";
            ServiciosGul = 0;
            ServiciosBafi = 0;
            Region = "";
            Supervisor = "";
            Coordinador = "";
            FechaOnAir = null;
        }

        public Pop(string networkElementType)
        {
            NetworkElementType = networkElementType;
            Nombre = "";
            Estado = "";
            Prioridad = "";
            TipoClienteFija = "";
            SitioBafi = "";
            ClienteAltoValor = "";
            Direccion = "";
            Departamento = "";
            Provincia = "";
            Distrito = "";
            Zona = "";
            Latitud = -1;
            Longitud = -1;
            TipoTorre = "";
            AlturaTorre = 0;
            TipoEstacion = "";
            AlturaEdificacion = 0;
            CoubicadorFinal = "";
            NombreSitioCoubicador = "";
            OperadorCoubicado = "";
            NombreSitioCoubicante = "";
            CodigoCoubicador = "";
            UbicacionEquipos = "";
            Agregador = "";
            PreAgregador = "";
            ProveedorDeMantenimiento = "";
            AccesoLibre24h = "";
            ServiciosGul = 0;
            ServiciosBafi = 0;
            Region = "";
            Supervisor = "";
            Coordinador = "";
            FechaOnAir = null;
        }


        string ObtenerServicios()
        {
            // Definición de variables
            string salida = "";
            string ag = "";
            string pag = "";
            string bafi = "";
            string gul = "";

            // Se realiza los cálculos
            if (Agregador.ToLower().Trim().Equals("si"))
            {
                ag = "AGG";
                salida = $"{salida} {ag}";
            }

            if (PreAgregador.ToLower().Trim().Equals("si"))
            {
                pag = "PAG";
                salida = $"{salida} + {pag}";
            }

            if (ServiciosBafi > 0)
            {
                bafi = "BAFI";
                salida = $"{salida} + {bafi}";
            }

            if (ServiciosGul > 0)
            {
                gul = $"GUL {ServiciosGul}";
                salida = $"{salida}, {gul}";
            }
            salida = salida.Trim();

            if (salida.Length > 0)
            {
                if (salida.Substring(0, 1).Equals("+") || salida.Substring(0, 1).Equals(","))
                {
                    salida = salida.Substring(1, salida.Length - 1);
                }
            }

            // fin
            return salida;
        }

        string ObtenerPrioridadServicios()
        {
            string salida = "";

            if (Servicios.Trim().Equals("") == true)
            {
                salida = Prioridad;
            }
            else
            {
                salida = $"{Prioridad} + {Servicios}";
            }

            return salida;
        }

        
        string ObtenerPopPrioridadServicios()
        {
            string salida = "";

            if (PrioridadServicios.Trim().Equals("") == true)
            {
                salida = Nombre;
            }
            else
            {
                salida = $"{Nombre} ({PrioridadServicios})";
            }


            return salida;
        }
        
    }
}
