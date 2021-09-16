using System;
using System.Collections.Generic;
using System.Text;

namespace simbogotaClassLibrary
{
    public class vehiculo
    {
        int clasevh { get; set; }
        public placa placa { get; set; }
        string marca { get; set; }
        string linea { get; set; }
        int combustible { get; set; }
        string colores { get; set; }
        string modelo { get; set; }
        string cilindrage { get; set; }
        int capacidad { get; set; }
        public blindajes blindajes { get; set; }
        public desmonteblindajes desmonteblindajes { get; set; }
        int potencia { get; set; }
        public importacionremates importacionremates { get; set; }
        public identificacioninternavehiculo identificacioninternavehiculo { get; set; }
        int tiposervicio { get; set; }
        int datoalerta { get; set; }
        public empresavinculadora empresavinculadora { get; set; }
    }
}
