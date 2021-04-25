using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParciaNo2.CLASES;

namespace ParciaNo2.ESTUDIANTE
{
    class Estudiante : Comparador
    {
        public string correo;
        public int id;
        public string nombres;
        public string apellidos;
        public string lab1;
        public string lab2;
        public string lab3;
        public string lab4;

        public Estudiante()
        {

        }
        //esta es la linea para buscar por correo
        //public Estudiante(string apellido, string nombre, string email, string carne, string labo1, string labo2, string labo3, string labo4)
        public Estudiante(int carne ,string apellido, string nombre, string email, string labo1, string labo2, string labo3, string labo4)
        {
            id = carne;
            apellidos = apellido;
            nombres = nombre;
            correo = email;
            lab1 = labo1;
            lab2 = labo2;
            lab3 = labo3;
            lab4 = labo4;
        }
        // este es de correo
        //public bool igualQue(object q)
        //{
        //    Estudiante Paux = (Estudiante)q;
        //    return (correo.Equals(Paux.correo));
        //}

            //este es de carne
        public bool igualQue(object q)
        {
            Estudiante Paux = (Estudiante)q;
            return id == Paux.id;
        }

        public bool mayorIgualQue(object q)
        {
            Estudiante Paux = (Estudiante)q;
            return id >= Paux.id;
        }

        //esto es para el buscar correo
        //public bool search(object q)
        //{
        //    Estudiante Paux = (Estudiante)q;
        //    bool aux = false;
        //    if (apellidos.CompareTo(Paux.apellidos) == 0)
        //    {
        //        aux = true;
        //    }
        //    else
        //    {
        //        aux = false;
        //    }
        //    return aux;
        //}
        //public bool search2(object q)
        //{
        //    Estudiante Paux = (Estudiante)q;
        //    bool aux = false;
        //    if (apellidos.CompareTo(Paux.id) > 0 || apellidos.CompareTo(Paux.id) < 0)
        //    {
        //        aux = true;
        //    }
        //    else
        //    {
        //        aux = false;
        //    }
        //    return aux;
        //}

        public bool mayorQue(object q)
        {
            Estudiante Paux = (Estudiante)q;
            return id  > Paux.id;
        }

        public bool menorIgualQue(object q)
        {
            Estudiante Paux = (Estudiante)q;
            return id <= Paux.id;
        }

        //esto es para correo
        //public bool menorQue(object q)
        //{
        //    Estudiante Paux = (Estudiante)q;
        //    bool aux = false;
        //    if (apellidos.CompareTo(Paux.id) > 0 || apellidos.CompareTo(Paux.id) < 0)
        //    {
        //        aux = true;
        //    }
        //    else
        //    {
        //        aux = false;
        //    }
        //    return aux;
        //}

        //esto es para carne
        public bool menorQue(object q)
        {
            Estudiante Paux = (Estudiante)q;
            return id < Paux.id;
        }

        public override string ToString()
        {
            return "(" + nombres + " , " + apellidos + " , " + id +")";
        }

    }
}
