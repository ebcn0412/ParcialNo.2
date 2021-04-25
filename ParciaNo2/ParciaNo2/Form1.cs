using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParciaNo2.CLASES.ARBOL_AVL;
using ParciaNo2.ESTUDIANTE;

namespace ParciaNo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArbolAVL arbol = new ArbolAVL();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\ebcn0\source\repos\ParciaNo2\ParciaNo2\listaAlumnosSegundoParcial.txt");
            Char delimiter = ',';
            while ((line = file.ReadLine()) != null)
            {
                String[] substrings = line.Split(delimiter);
                Estudiante nuevo = new Estudiante(Convert.ToInt32(substrings[0]), substrings[1], substrings[2], substrings[3], substrings[4], substrings[5],
                        substrings[6],substrings[7]);
                //Convert.ToInt32(substrings[4]), Convert.ToInt32(substrings[5]), 
                //Convert.ToInt32(substrings[6]), Convert.ToInt32(substrings[7]));
                arbol.insertar(nuevo);
                counter++;
            }
            file.Close();
            MessageBox.Show("REGISTRO CORRECTO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            textBox2.Text = ArbolAVL.preorden(arbol.raizArbol());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 salto = new Form2();
            salto.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            textBox2.Text = ArbolAVL.inorden(arbol.raizArbol());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            textBox2.Text = ArbolAVL.postorden(arbol.raizArbol());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                Char delimiter = ',';
                while ((line = file.ReadLine()) != null)
                {
                    String[] substrings = line.Split(delimiter);
                    Estudiante nuevo = new Estudiante(Convert.ToInt32(substrings[0]), substrings[1], substrings[2], substrings[3], substrings[4], substrings[5],
                        substrings[6],substrings[7]);
                        //Convert.ToInt32(substrings[4]), Convert.ToInt32(substrings[5]),
                        //Convert.ToInt32(substrings[6]), Convert.ToInt32(substrings[7]));
                    arbol.insertar(nuevo);
                    
                }
                file.Close();
                MessageBox.Show("REGISTRO CORRECTO");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //esto es para correo
            //Estudiante buscamos = new Estudiante(Convert.ToInt32(txtSearch), " ", " ", " ", " ", " ", " "," ");
            //arbol.buscar(buscamos);
            //Estudiante exito = (Estudiante)arbol.buscar(buscamos).valorNodo();
            //textBox2.Text = exito.ToString();
            int val1, val2, val3, val4, promedio;
            Estudiante ObjEstudianteBuscado = new Estudiante(Convert.ToInt32(txtSearch.Text), "", "", "", "", "", "", "");
            Estudiante ObjEstudianteEncontrado = (Estudiante)arbol.buscar(ObjEstudianteBuscado).valorNodo();
            txtRespuesta.Text = ObjEstudianteEncontrado.correo;
            textBox3.Text = ObjEstudianteEncontrado.nombres + " " + ObjEstudianteEncontrado.apellidos;
            textBox4.Text = ObjEstudianteEncontrado.lab1;
            textBox5.Text = ObjEstudianteEncontrado.lab2;
            textBox6.Text = ObjEstudianteEncontrado.lab3;
            textBox7.Text = ObjEstudianteEncontrado.lab4;
            val1 = Convert.ToInt32(ObjEstudianteEncontrado.lab1);
            val2 = Convert.ToInt32(ObjEstudianteEncontrado.lab2);
            val3 = Convert.ToInt32(ObjEstudianteEncontrado.lab3);
            val4 = Convert.ToInt32(ObjEstudianteEncontrado.lab4);
            promedio = (val1 + val2 + val3 + val4)/4;
            textBox8.Text = ("SU PROMEDIO ES DE: " + promedio);
            if (promedio >= 6)
            {
                textBox9.Text = "APROVADO";

            }
            else
            {
                textBox9.Text = "REPROBADO";
            }
        }
    }
}
