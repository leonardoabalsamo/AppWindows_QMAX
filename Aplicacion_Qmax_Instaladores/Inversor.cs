using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Qmax_Instaladores
{
    [Serializable]
    public class Inversor
    {
        private string modelo;
        private int tension_nominal;
        private int potencia;

        public Inversor(string m, int tn, int p)
        {
            modelo = m;
            tension_nominal = tn;
            potencia = p;
        }

        public string modelo_inversor { get { return modelo; } set { modelo = value; } }
        public int tension_nominal_inversor { get { return tension_nominal; } set { tension_nominal = value; } }
        public int potencia_inversor { get { return potencia; } set { potencia = value; } }

    }
}
