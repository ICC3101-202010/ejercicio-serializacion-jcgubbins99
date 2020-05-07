using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Serialización
{
    [Serializable]
    public class Person
    {
        private string Nombre;
        private string Apellido;
        private int Edad;

        public string nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return Apellido;
            }
            set
            {
                Apellido = value;
                
            }
        }

        public int edad
        {
            get
            {
                return Edad;
            }
            set
            {
                Edad = value;
            }
        }

        public Person(string _nombre, string _apellido, int _edad)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.edad = _edad;
        }
        public string information()
        {
            string informacion = ("Nombre: " + Nombre + "\n" + "Apellido: " + Apellido + "\n" + "Edad: " + Edad);
            return informacion;
        }
    }
}
