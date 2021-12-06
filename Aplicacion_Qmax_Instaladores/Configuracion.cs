using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Qmax_Instaladores
{
    public partial class Configuracion : Form
    {
        Sistema sistema;
        Form Anterior;
        private Bateria bat;
        private Inversor inv;
        private string Tipo_Solucion;
        private int cantidad;


        public Configuracion(Sistema s, Form a, Bateria b, Inversor i, string tiposol, int cant)
        {
            sistema = s;
            Anterior = a;
            bat = b;
            inv = i;
            Tipo_Solucion = tiposol;
            cantidad = cant;
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            Texto_Modo.Text = Tipo_Solucion;
            Texto_Perfil.Text = bat.modelo_bateria;
            Texto_Capacidad.Text = (bat.capacidad_bateria * cantidad).ToString();
        }
    }
}

