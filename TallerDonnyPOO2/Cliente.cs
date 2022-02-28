using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDonnyPOO2
{
    internal class Cliente
    {
        string Nombre;
        string Documento;
        string Direccion;
        int Telefono;

        public void Setnombre(string nombre)
        {
            Nombre = nombre;
        }
        public void Setdocumento(string documento)
        {
            Documento = documento;
        }
        public void Setdireccion(string direccion)
        {
            Direccion = direccion;
        }
        public void Setdtelefono(int telefono)
        {
            Telefono = telefono;
        }

        public string Getnombre()
        {
            return Nombre;
        }
        public string Getdocumento()
        {
            return Documento;
        }
        public string Getdireccion()
        {
            return Direccion;
        }
        public int Gettelefono()
        {
            return Telefono;
        }


        static void ValidarDocumento(string documento)
        {

        }

        public void Crearcliente()
        {
            //ACA SE COMIENZAN A LLENAR LOS DATOS DEL OBJETO.

            Console.WriteLine("Ingrese el nombre");
            Setnombre(Console.ReadLine());
            Console.WriteLine("Ingrese la direccion");
            Setdireccion(Console.ReadLine());
            Console.WriteLine("Ingrese el telefono");
            Setdtelefono(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el numero de la Cedula ");
            Setdocumento(Console.ReadLine());
        }



        public void Menu() //ACA SE CREA EL MENU QUE LE DA LA OPCION AL USUARIO DE LO QUE DESEA HACER .
        {
            Console.WriteLine("\nSeleccione una opcion");
            Console.WriteLine("\n1. Crear  Cliente");
            Console.WriteLine("\n2. Buscar Cliente");
            Console.WriteLine("\n3. Modificar Cliente");
            Console.WriteLine("\n4. Eliminar Cliente");
            Console.WriteLine("\n5.Salir");

        }
        public int Buscarcliente(int documento)
        {

            return 0;
        }
        public void Modificarcliente()
        {

        }
        public void Eliminarcliente()
        {

        }
    }



}
