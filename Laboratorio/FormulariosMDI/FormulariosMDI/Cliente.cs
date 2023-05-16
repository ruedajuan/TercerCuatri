using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulariosMDI
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Cliente(int id,string nombre,string telefono,
            string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
