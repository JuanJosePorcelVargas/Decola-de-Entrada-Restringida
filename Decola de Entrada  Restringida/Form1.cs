using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decola_de_Entrada__Restringida
{
    public partial class Form1 : Form

    {
        Decola mensajero = new Decola();

        public void mostrarDecola()
       
        {
            listView1.Clear();
            for (int i = 0; i <= mensajero.ultimo; i++)
            {
                listView1.Items.Add(mensajero.lista[i].ToString());

            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensajero.insertar_ultimo(Int32.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
            mostrarDecola();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensajero.eliminar_primero();
            mostrarDecola();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mensajero.eliminar_ultimo();
            mostrarDecola();
        }
    }
}
