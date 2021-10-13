using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decola_de_Entrada__Restringida
{
    class Decola
    {
        static int maxCola = 6;
        public int primero;
        public int ultimo;
        public int[] lista;


        public Decola()
        {
            primero = 0;
            ultimo = -1;
            lista = new int[maxCola];
        }

        public bool vacia()
        {
            if (ultimo < primero)
                return true;
            else

                return false;




        }
        public bool llena()
        {
            if (ultimo == maxCola - 1)
                return true;
            else
                return false;

        }




        public void insertar_ultimo(int elemento)
        {
            if (llena())
                MessageBox.Show("La cola esta llena,No puede insertar mas elementos");
            else
            {
                ultimo++;
                lista[ultimo] = elemento;



            }

        }
        public void eliminar_primero()
        {
            if (vacia())
                MessageBox.Show("La cola esta vacia,No puede eliminar mas elementos");
            else
            {
                MessageBox.Show("El elemento a eliminar es: " + lista[primero]);
                for (int i = 0; i <= ultimo - 1; i++)// Para que al eliminar recorra su posicion anterior
                {
                    lista[i] = lista[i + 1];

                }
                ultimo--;

            }



        }
        public void eliminar_ultimo()
        {
            if (vacia())
                MessageBox.Show("La cola esta vacia,no puede eliminar mas elementos");
            else
            {
                MessageBox.Show("El elemento a eliminar es: " + lista[ultimo]);
                ultimo--;


            }




        }



    }
}
