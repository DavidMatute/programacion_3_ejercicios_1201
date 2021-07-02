using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class frm_CrearMatriz : Form
    {
        public frm_CrearMatriz()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            Crear_Matriz();
        }

        private void Crear_Matriz()
        {
            int Filas = Convert.ToInt32(txt_Filas.Text);
            int Columnas = Convert.ToInt32(txt_Columnas.Text);
            var randomNumber = new Random();

            int[,] Crear_Matriz = new int[Filas, Columnas];

            for (int i = 0; i < Crear_Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Crear_Matriz.GetLength(1); j++)
                {
                    Crear_Matriz[i, j] = randomNumber.Next(0, 100);

                }
            }

            for (int i = 0; i < Crear_Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Crear_Matriz.GetLength(1); j++)
                {

                    MessageBox.Show($"La posición es  ({i},{j}) = {Crear_Matriz[i, j].ToString()}");
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txt_Filas.Clear();
            txt_Columnas.Clear();
            txt_Filas.Focus();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            Close();
        }
    }
}
