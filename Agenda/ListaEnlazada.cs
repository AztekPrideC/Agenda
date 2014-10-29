using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    class ListaEnlazada
    {
        public Nodo cabeza;
        public Nodo cola;

        public ListaEnlazada()
        {
            cabeza = cola = null;
        }


        public bool vacia()
        {
            if (cabeza == null)
            {
                return true;// no hay elementos 
            }
            else return false; // si hay elementos 
        }

        public void insertar(string nombre,string direccion, string telefono, string email)
        {
            Nodo nuevo = new Nodo(nombre, direccion, telefono, email);
            
            if (vacia())
            {
                
                cabeza = cola = nuevo;// si solo hay un dato

            }
            else
            {
                cola.sig = nuevo;// si hay mas de dos elementos
                nuevo.ant = cola;
                cola = nuevo;
            }
            cabeza.ant = cola;
            cola.sig = cabeza;
        }


        public void cambiar(string nombre, string direccion, string telefono, string email)
        {

            Nodo compa = cabeza;
            if (vacia())
                MessageBox.Show("No hay a quien remplazar esta vacia");
            while (compa != null)
            {
                if (compa.nombre == nombre)
                {

                    compa.direccion = direccion;
                    compa.telefono = telefono;
                    compa.email = email;
                    break;
                }
                else
                {

                    compa=compa.sig;

                }
            }
        }//termina 

        public Nodo busca(string nombre)
        {
            Nodo r=null;
            Nodo act = cabeza;
            if (vacia()){
                  MessageBox.Show("lista vacia");
                  r = null;}
            while (act != null) {
                if (act.nombre == nombre) {
                    r = act;
                    break;
                } 
                else
                {

                    act = act.sig;

                }
            }//acaba while
            return r;
        }



        //saber como se elimina con dos punteros auxiliares  con while con if y con  la lista doblemente enlazada  
        //public void delate
        //circular // cabeza.ant=cola; // cola.sig=cabeza;



        public void eliminar(string datoo)
        {
            // Nodo ant = null;
            Nodo act = cabeza;

            if (vacia())
                MessageBox.Show("lista vacia");

            while (act != null)
            {
                if (act.nombre == datoo)
                {
                    if (act == cabeza)
                    {
                        cabeza = cabeza.sig;
                        cabeza.ant = null;
                        act.sig = null;
                    }
                    else if (act == cola)
                    {
                        cola = cola.ant;
                        cola.sig = null;
                        act.ant = null;

                    }
                    else
                    {
                        act.ant.sig = act.sig;
                        act.sig.ant = act.ant;

                    }
                    cabeza.ant = cola;
                    cola.sig = cabeza;
                    break;
                }
                else
                {

                    act = act.sig;
                }

            }
        }//ternina eliminar


          public void modificar(string buscar, string reemplazo) {
            
            Nodo act = cabeza;

            while (act != null) {
                if (act.nombre == buscar) {
                    act.nombre = reemplazo;
                    break;

                }
                act = act.sig;
            }

                   }//termina mdificar
      
    
    
    
    
    
    }

    }

