using System;
using System.Collections.Generic;

namespace TallerDonnyPOO2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int respuesta;
           
            Cliente clienteuno = new();//instanciar
            List<Cliente> listaCliente = new();//se crea la lista de tipo clase


            //ACA CREAMOS EL MENU QUE SEA UTILIZABLE VARIAS VECES

            clienteuno.Menu();
            do
            {
               
                respuesta = int.Parse(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        //se crea el cliente
                        Console.WriteLine("Ingrese el nombre de la persona");
                        clienteuno.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese direccion");
                        clienteuno.Direccion = Console.ReadLine();

                        Console.WriteLine("Ingrese telefono");
                        clienteuno.Telefono =int.Parse( Console.ReadLine());

                        Console.WriteLine("ingrese numero del documento");
                        clienteuno.Documento = Console.ReadLine();
                        listaCliente.Add(clienteuno);//aca agrega a la lista un objeto tipo cliente
                        

                      break;
                    case 2:
                        //se busca el cliente
                        Console.WriteLine("ingrese el documento del cliente");
                        clienteuno.validarDocumento = Console.ReadLine();

                        if (clienteuno.validarDocumento==clienteuno.Documento)
                        {
                            Console.WriteLine("El  nombre es : "+clienteuno.Nombre);
                            Console.WriteLine("La Direccion : "+clienteuno.Direccion);
                            Console.WriteLine("Telefono :"+clienteuno.Telefono);

                        }
                     
                        break;
                    case 3:
                   
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        Console.WriteLine("SE SALIO DEL PROGRAMA EXITOSAMENTE");
                        break;


                }
                Console.WriteLine("\nSeleccione otra opcion");
            } while (respuesta !=5);
           

        
            Console.ReadKey();



        }
    }
}
