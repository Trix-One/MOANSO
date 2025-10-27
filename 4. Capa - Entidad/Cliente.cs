using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Capa___Entidad
{
    public class Cliente
    {
        private int ClienteId { get; set; }
        private string Nombres { get; set; }
        private string Apellidos { get; set; }
        private string DocumentoIdentificacion { get; set; }
        private string Direccion { get; set; }
        private string Telefono { get; set; }
        private string ZonaAsignada { get; set; }
        private string Pdf { get; set; }
        private bool Estado { get; set; }
    }
}
