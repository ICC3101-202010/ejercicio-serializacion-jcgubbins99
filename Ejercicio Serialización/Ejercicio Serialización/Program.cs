using System;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Ejercicio_Serialización
{
    class Program
    {
        static void Main()
        {

            List<Person> listapersonas = new List<Person>();

            string accion = null;
            while (accion != "4")
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Almacenar");
                Console.WriteLine("2. Cargar");
                Console.WriteLine("3. Ver lista de usuarios");
                Console.WriteLine("4. Salir");

                accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=====================");
                        Console.WriteLine("Crear persona");
                        Console.WriteLine("=====================");
                        string nombre = "";
                        string apellido = "";
                        int edad = 0;
                        Console.WriteLine("Ingrese su nombre ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su apellido");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese edad");
                        edad = Convert.ToInt32(Console.ReadLine());
                        Person p = new Person(nombre, apellido, edad);
                        listapersonas.Add(p);
                        Almacenar(listapersonas);
                        break;
                    case "2":
                        Cargar(listapersonas);
                        break;
                    case "3":
                        VerPersonas(listapersonas);
                        break;
                    case "4":
                        Console.WriteLine("Has salido");
                        break;
                    default:
                        Console.WriteLine("No has seleccionado ninguna opcion valida");
                        break;
                }
            }


            void Almacenar(List<Person> p)      //Serializamos
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, listapersonas);
                stream.Close();

            }
            void Cargar(List<Person> p)
            {
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream = new FileStream("Usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, listapersonas);
                p = (List<Person>)formatter2.Deserialize(stream);
                stream.Close();
                VerPersonas(p);
            }
            void VerPersonas(List<Person> lista)
            {
                if (lista.Count == 0)
                {
                    Console.WriteLine("No hay personas agregadas aún");
                }

                else
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine("============");
                        Console.WriteLine("Persona" + " " + (i + 1));
                        Console.WriteLine("============");
                        Console.WriteLine(lista[i].information());
                        Console.WriteLine(" ");

                    }
                }


            }
        }
    }
}
