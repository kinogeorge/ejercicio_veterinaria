using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_veterinaria.models
{
    public class Perro : UnionToAnimales
    {
        public bool Guardian;
        public bool Pastoreo;
        public bool Guia;
    }
}
