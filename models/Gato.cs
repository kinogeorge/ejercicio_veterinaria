using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_veterinaria.models
{
    public class Gato : UnionToAnimales
    {
        public bool Caza;
        public bool Alergias;
    }
}
