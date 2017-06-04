using System;
/*
 * AUTOR=LUIS ALFREDO SUAREZ LITARDO
 * 2017-06-03
 * CLASE MAQUINA DE TICKETS
 * TELEMÁTICA 4TO MÓDULO
 */
namespace MaquinaTicket
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MaquinaTicket ();
		}




		static void MaquinaTicket(){
		
			int costo;
			//Instanciar el Objeto
			while (true) {
				Console.WriteLine ("Insertar el costo del ticket(constructor): ");
				costo = int.Parse (Console.ReadLine());
				if (costo > 0) {
					break;
				} else {
					Console.WriteLine ("Ingrese un Costo Mayor a 0");
				}
				Console.ReadKey ();
				Console.Clear ();
					
			}
			MaquinaTicket maquina1 = new MaquinaTicket (costo);
			Menu menu1 = new Menu ();
			//LIMPIAR LA CONSOLA
			Console.Clear ();
			while (true) {
				menu1.getMenu ();
				Console.Write ("Ingrese una opción: ");
				string opcion = Console.ReadLine ();
				switch (opcion) {

				case "1":
					Console.Write ("---Inserte una moneda: ");
					int moneda = int.Parse (Console.ReadLine ());
					maquina1.Balance += moneda;
					break;

				case "2":
					Console.WriteLine ("---PRECIO DEL TICKET ---> {0}",maquina1.Precio);
					Console.ReadKey ();
					break;

				case "3":
					Console.WriteLine ("---BALANCE ---> {0}", maquina1.Balance);
					Console.ReadKey ();
					break;

				case "4":
					Console.WriteLine ("---REEMBOLSO BALANCE ---> {0}", maquina1.reembolsoBalance);
					Console.ReadKey ();
					break;

				case "5":
					maquina1.ImprimirTicket ();
					Console.ReadKey ();
					break;

				case "6":
					Console.WriteLine ("---TOTAL EN MAQUINA ---> {0}", maquina1.VaciarMaquina);
					Console.WriteLine ("--LA MAQUINA ESTA VACIA");
					Console.ReadKey ();
					break;
				case "7":
					Console.WriteLine ("---TICKETS VENDIDOS --> {0}", maquina1.ContadorTicket);
					Console.WriteLine ("---TOTAL -------------> {0}", maquina1.Total);
					Console.ReadKey ();
					break;

				case "8":
					Environment.Exit (0);
					break;

				default:
					Console.WriteLine ("---Inserte un opción entre 1 y 7");
					Console.ReadKey ();
					break;
				}
				Console.Clear ();
			}
		}
	}
}
