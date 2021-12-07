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
    public partial class Form2 : Form
    {
        Sistema sistema;
        Form anterior;
        private Form config;
        private List<string> Tipo_instalacion;
        private List<string> Tiene_sino;
        private List<string> Tipo_solucion;

        private Bateria bat;
        private Inversor inv;

        private string tiposol;
        private int cantidad;

        public Form2(Sistema s, Form f, Bateria b, Inversor i, int cant)
        {
            anterior = f;
            sistema = s;
            anterior = f;
            bat = b;
            inv = i;
            cantidad = cant;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Tipo_instalacion = new List<string>() { "Estacionaria", "Vehículos " };
            Tiene_sino = new List<string>() { "Si", "No" };         
            Tipo_solucion = new List<string>() { "Autoconsumo", ("Backup") };


            comboBox1.DataSource = Tipo_instalacion;
            comboBox1.SelectedIndex = 1;
            comboBox2.DataSource = Tiene_sino;
            comboBox2.SelectedIndex = 1;
            comboBox3.DataSource = Tipo_solucion;

            comboBox2.Visible = false;
            comboBox3.Visible = false;
            red_elec.Visible = false;
            solucion.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Equals(comboBox1.SelectedItem.ToString() , "Estacionaria"))
            {
                red_elec.Visible = true;
                comboBox2.Visible = true;
            }
            else
            {
                // indica que es una solucion de vehiculos y debemos armar la config
                tiposol = "Vehiculos";                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Equals(comboBox2.SelectedItem.ToString(), "Si"))
            {
                comboBox3.Visible = true;
            }
            else
            {
                // indica que es una solucion con grupo y debemos armar la config
                tiposol = "Aislada_Grupo";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Equals(comboBox3.SelectedItem.ToString(), "Autoconsumo"))
            {
                // Indica que es una solucion de autoconsumo y debemos armar la config
                tiposol = "Autoconsumo";
            }
            else if (Equals(comboBox3.SelectedItem.ToString(), "Backup"))
            {
                // indica que es una solucion de backup y debemos armar la config
                tiposol = "Backup";              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config = new Configuracion(sistema, this, bat, inv, tiposol, cantidad);
            config.Show();
            this.Hide();
        }
    }
}
