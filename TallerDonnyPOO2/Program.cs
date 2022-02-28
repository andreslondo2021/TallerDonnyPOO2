using System;

namespace TallerDonnyPOO2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int respuesta;

            Cliente clienteuno = new();//instanciar


            //ACA CREAMOS EL MENU QUE SEA UTILIZABLE VARIAS VECES

            clienteuno.Menu();
            do
            {
               
                respuesta = int.Parse(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        clienteuno.Crearcliente();
                      break;
                    case 2:
                      //  clienteuno.Buscarcliente();
                        break;
                    case 3:
                        clienteuno.Modificarcliente();
                        break;
                    case 4:
                        clienteuno.Eliminarcliente();
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
