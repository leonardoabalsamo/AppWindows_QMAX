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
            Carga_Config();
            Texto_Modo.Text = Tipo_Solucion;
        }

        private void Carga_Config()
        {

            if (Equals(Tipo_Solucion.ToString(), "Aislada_Grupo"))
            {
                Texto_Modo.Text = " Inversor/Cargador ";
                textConfig.Text = 
                    "Perfil de Entrada: Tolerante" + 
                    "Capacidad del Banco:" + " Ah ";
            }

            if (Equals(Tipo_Solucion.ToString(), "Vehiculos"))
            {
                Texto_Modo.Text = " Inversor/Cargador ";
                textConfig.Text = "Perfil de Entrada: Tolerante" + " Capacidad del Banco:" + " Ah ";
            }

            if (Equals(Tipo_Solucion.ToString() , "Backup"))
            {
                Texto_Modo.Text = " Inversor/Cargador ";

                textConfig.Text =                     
                    "Perfil de Entrada: Estricta" + 
                    "Capacidad del Banco:" + " Ah ";
            }

            if (Equals(Tipo_Solucion.ToString(), "Autoconsumo"))
            {
                Texto_Modo.Text = " Autoconsumo ";

                textConfig.Text = 
                    "Perfil de Entrada: Estricta" + 
                    "Capacidad del Banco:" + " Ah " +
                    "Tensión de batería de cierre de derivación: " + "" +
                    "Tensión de batería para apertura de derivación: " + ""
                    ;
            }

        }

    }
}

