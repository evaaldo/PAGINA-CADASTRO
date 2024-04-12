using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTelefonia.Models
{
    public class NumeroCliente
    {
        public int ID { get; set; }
        public string? Numero { get; set; }
        public string? Operadora { get; set; }
        public string? Departamento { get; set; }
        public bool Desativacao { get; set; }
        public bool Virtual { get; set; }
    }
}