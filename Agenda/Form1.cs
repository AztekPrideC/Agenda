using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{

    


    public partial class Form1 : Form
    {

        ListaEnlazada lista = new ListaEnlazada();
        Nodo ra;
        public Form1()
        {
         
            InitializeComponent();
            ra = lista.cabeza;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.insertar(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Nodo n= lista.busca(txtNombre.Text);

           txtNombre.Text = n.nombre;
           txtDireccion.Text = n.direccion;
           txtTelefono.Text = n.telefono;
           txtEmail.Text = n.email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.eliminar(txtNombre.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           ra = lista.cabeza;
           txtNombre.Text = ra.nombre;
           txtDireccion.Text = ra.direccion;
           txtTelefono.Text = ra.telefono;
           txtEmail.Text = ra.email;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ra = lista.cola;
            txtNombre.Text = ra.nombre;
            txtDireccion.Text = ra.direccion;
            txtTelefono.Text = ra.telefono;
            txtEmail.Text = ra.email;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ra = ra.sig;
            txtNombre.Text = ra.nombre;
            txtDireccion.Text = ra.direccion;
            txtTelefono.Text = ra.telefono;
            txtEmail.Text = ra.email;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ra = ra.ant;
            txtNombre.Text = ra.nombre;
            txtDireccion.Text = ra.direccion;
            txtTelefono.Text = ra.telefono;
            txtEmail.Text = ra.email;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.cambiar(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
        }
    }
}
