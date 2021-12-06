using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Qmax_Instaladores
{
    [Serializable]
    public class Bateria
    {
        protected string tipo;
        protected string modelo;
        protected float fondo;
        protected float flote;
        protected int capacidad;
        protected int tension_nominal;

        public Bateria(string t, string n, float f, float fl, int c, int tn)
        {
            tipo = t;
            modelo = n;
            fondo = f;
            flote = fl;
            capacidad = c;
            tension_nominal = tn;
        }

        public int tension_nominal_bateria { get { return tension_nominal; } set { tension_nominal = value; } }
        public int capacidad_bateria { get { return capacidad; } set { capacidad = value; } }

        public string modelo_bateria { get { return modelo; } set { modelo = value; } }

    }
}
