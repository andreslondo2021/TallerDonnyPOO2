using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDonnyPOO2
{
    internal class Cliente
    {
      public  string Nombre;
        public string Documento;
        public string Direccion;
        public int Telefono;
        public string validarDocumento;

        /*
         
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
        */




        public void Menu() //ACA SE CREA EL MENU QUE LE DA LA OPCION AL USUARIO DE LO QUE DESEA HACER .
        {
            Console.WriteLine("\nSeleccione una opcion");
            Console.WriteLine("\n1. Crear  Cliente");
            Console.WriteLine("\n2. Buscar Cliente");
            Console.WriteLine("\n3. Modificar Cliente");
            Console.WriteLine("\n4. Eliminar Cliente");
            Console.WriteLine("\n5.Salir");

        }

        

    }



}
