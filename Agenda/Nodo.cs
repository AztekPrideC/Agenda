using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Nodo
    {

        public string nombre;   //informacion
        public string direccion;
        public string telefono;
        public string email;
        public Nodo sig;   //Enlace con el sig nodo
        public Nodo ant; // enlace con el anterior ndo 

        public Nodo(string dato)
        {
            this.nombre = dato;
            this.sig = null;
            this.ant = null;
        }
        public Nodo(string nombre, string direccion, string telefono, string email)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;

            this.sig = null;
            this.ant = null;
        }

        public Nodo(string dato, Nodo sig, Nodo ant)
        {
            this.nombre = dato;
            this.sig = sig;
            this.ant = ant;


        }
    }
}
