using ParciaNo2.CLASES.ARBOL_AVL;
using ParciaNo2.ESTUDIANTE;
using System;
using System.Windows.Forms;

namespace ParciaNo2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArbolAVL arbol = new ArbolAVL();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante ObjEstudianteBuscado = new Estudiante(Convert.ToInt32(txtBuscar.Text), "", "", "", "", "", "", "");
            Estudiante ObjEstudianteEncontrado = (Estudiante)arbol.buscar(ObjEstudianteBuscado).valorNodo();
            textBox2.Text = ObjEstudianteEncontrado.correo;
            textBox3.Text = ObjEstudianteEncontrado.nombres + " " + ObjEstudianteEncontrado.apellidos;
            textBox4.Text = ObjEstudianteEncontrado.lab1;
            textBox5.Text = ObjEstudianteEncontrado.lab2;
            textBox6.Text = ObjEstudianteEncontrado.lab3;
            textBox7.Text = ObjEstudianteEncontrado.lab4;


        }
    }
}
