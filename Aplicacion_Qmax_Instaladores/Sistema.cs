using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Qmax_Instaladores
{
    [Serializable]
    public class Sistema
    {
        private List<Bateria> Lista_Baterias;
        private List<Inversor> Lista_Inversores;
        private List<int> Lista_Cantidad;


        public Sistema()
        {
            // Lista de baterias - Luego se realizará la consulta en la tabla de la BD
            Lista_Baterias = new List<Bateria>();
            Lista_Baterias.Add(new Bateria("PbAcido", "T105", 7.41f, 6.75f, 225, 6));
            Lista_Baterias.Add(new Bateria("PbAcido", "T605", 7.41f, 6.75f, 225, 6));

            // Lista de inversores SPD disponibles
            Lista_Inversores = new List<Inversor>();
            Lista_Inversores.Add(new Inversor("QM-1212-SPD", 12, 1200));
            Lista_Inversores.Add(new Inversor("QM-2312-SPD", 12, 2300));
            Lista_Inversores.Add(new Inversor("QM-1224-SPD", 24, 1200));
            Lista_Inversores.Add(new Inversor("QM-2324-SPD", 24, 2300));
            Lista_Inversores.Add(new Inversor("QM-1248-SPD", 48, 1200));
            Lista_Inversores.Add(new Inversor("QM-2348-SPD", 48, 2300));
            Lista_Inversores.Add(new Inversor("QM-3524-SPD", 24, 3500));
            Lista_Inversores.Add(new Inversor("QM-4548-SPD", 48, 4500));

            Lista_Cantidad = new List<int>() { 1, 2, 4, 6, 8, 12, 16, 32 };
            

        }



        // metodo para cargar una nueva instancia de baterias
        private void carga_nueva_bateria(string tipo, string modelo, float fondo, float flote, int capacidad, int nominal)
        {
            Lista_Baterias.Add(new Bateria(tipo, modelo, fondo, flote, capacidad, nominal));
        }

        // metodo para cargar una nueva instancia de inversores
        private void carga_nuevo_inversor(string modelo, int nominal, int potencia)
        {
            Lista_Inversores.Add(new Inversor(modelo, nominal, potencia));
        }

        public List<int> carga_tensiones()
        {
            List<int> Lista_tension = new List<int>();

            foreach (var item in Lista_Cantidad)
            {
                Lista_tension.Add(item);
            }

            return Lista_tension;
        }

        public List<String> carga_inversores()
        {
            List<string> modelos = new List<string>();

            foreach (var item in Lista_Inversores)
            {
                modelos.Add(item.modelo_inversor);
            }

            return modelos;
        }
        public List<String> carga_baterias()
        {
            List<string> modelos = new List<string>();

            foreach (var item in Lista_Baterias)
            {
                modelos.Add(item.modelo_bateria);
            }

            return modelos;
        }

        /* Metodo que recibe un string y retorna el inversor*/
        public Inversor verifica_inversor(string inv)
        {
            Inversor aux = new Inversor("", 0, 0);
            foreach (var item in Lista_Inversores)
            {
                if (string.Equals(inv, item.modelo_inversor))
                {
                    aux = item; // retorno el inversor
                }
            }
            return aux;
        }

        /* Metodo que recibe un string y retorna la batería */
        public Bateria verifica_bateria(string bat)
        {
            Bateria aux = new Bateria("", "", 0, 0, 0, 0);
            foreach (var item in Lista_Baterias)
            {
                if (string.Equals(bat, item.modelo_bateria))
                {
                    aux = item; // retorno la bateria
                }
            }
            return aux;
        }
    }
}
