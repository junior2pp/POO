using System;
/*
 * AUTOR=LUIS ALFREDO SUAREZ LITARDO
 * 2017-06-03
 * CLASE MAQUINA DE TICKETS
 * TELEMÁTICA 4TO MÓDULO
 */
namespace MaquinaTicket
{
	public class Menu
	{
		public Menu ()
		{
			
		}

		public void getMenu(){
		
			Console.WriteLine ("1.Insertar Moneda");
			Console.WriteLine ("2.Obtener Precio");
			Console.WriteLine ("3.Obtener Balance");
			Console.WriteLine ("4.Reembolso Balance");
			Console.WriteLine ("5.Imprimir Ticket");
			Console.WriteLine ("6.Vaciar Máquina");
			Console.WriteLine ("7.Obtener Cantidad de Tickets Vendidos");
			Console.WriteLine ("8.Salir");
		}
	}
}

