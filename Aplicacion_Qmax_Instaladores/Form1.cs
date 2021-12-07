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
    public partial class Form1 : Form
    {
        private Sistema sistema;
        private Form form2;
        private string seleccion_inversor;
        private string seleccion_bateria;
        private int seleccion_cantidad;
        private int aux;

        private Bateria bat = new Bateria("", "", 0, 0, 0, 0);
        private Inversor inv = new Inversor("", 0, 0);

        public Form1(Sistema s)
        {
            sistema = s;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = sistema.carga_inversores();

            comboBox2.DataSource = sistema.carga_baterias();

            comboBox3.DataSource = sistema.carga_tensiones();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion_inversor = comboBox1.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion_bateria = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion_cantidad = Int32.Parse(comboBox3.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inv = sistema.verifica_inversor(seleccion_inversor);
            bat = sistema.verifica_bateria(seleccion_bateria);

            if (validacion()==true)
                {
                    form2 = new Form2(sistema, this, bat, inv, seleccion_cantidad); // paso la referencia de este form al siguiente
                    form2.Show();
                    this.Hide();
                }
            else 
                {
                    // Mensaje que ha seleccionado una configuración incorrecta
                    string message = "Ha ingresado una cantidad de baterías inválida, por favor ingrese una nueva opción";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult resultado;

                    // Displays the MessageBox.
                    resultado = MessageBox.Show(message, caption, buttons);
                    if (resultado == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Show();
                    }
                }        
            
            
        }


        //Validaciones

        private bool validacion()
        {          
            //Validaciones contando con el inversor + baterias + cantidad baterias
            // cantidad de baterias
            // ( tension de inversor / tension de bateria )
            // aux x 1 = 1 banco
            // aux x 2 = 2 bancos
            // aux x 3 = 3 bancos
            // aux x 4 = 4 bancos

            aux = inv.tension_nominal_inversor / bat.tension_nominal_bateria; 

            if (seleccion_cantidad == aux | seleccion_cantidad == (aux * 2)
            | seleccion_cantidad == (aux * 3) | seleccion_cantidad == (aux * 4))
            {
                return true;
            }
            else return false;
        }
    }
}
