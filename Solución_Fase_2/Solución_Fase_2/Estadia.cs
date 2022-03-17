using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solución_Fase_2
{
    //Inicializacíon de la clase Estadia
    internal class Estadia
    {
        //atributos de la clase
        public string nombre { get; set; }
        public string identificación { get; set; }
        public string genero { get; set; }
        public string tipohab { get; set; }
        public string dias { get; set; }
        public decimal costo { get; set; }

        //creacion del metodo para calcular
        public decimal cacularhospedaje(int dias, decimal costo)
        {
            decimal totalestadia = 0;
            totalestadia = dias * costo;
            return totalestadia;
        }
    }
}
