using System;

/*
 * AUTOR=LUIS ALFREDO SUAREZ LITARDO
 * 2017-06-03
 * CLASE MAQUINA DE TICKETS
 * TELEMÁTICA 4TO MÓDULO
 */
namespace MaquinaTicket
{
	public class MaquinaTicket
	{

		private int precio;
		private int balance;
		private int total;
		private int contadorTicket;

		public MaquinaTicket (int ticketCost)
		{
			if (ticketCost>0) {
				Precio = ticketCost;
				Balance = 0;
				total = 0;
				ContadorTicket = 0;
			}

		}
		//METODOS MODIFICADORES
		public int Precio
		{
			get{
				return precio;
			}
			set{
				if (value > 0) {
					precio = value;
				}
			}
		}
		//Obtener Balance y setear balance
		public int Balance
		{
			get{
				return balance;
			}
			set{
				if (value >= 0) {
					balance = value;
				}
			}
		}
		public int ContadorTicket{
			get{
				return contadorTicket;
			}
			set {
				if (value >= 0) {
					contadorTicket = value;
				}
			}
		}
		public int Total{
			get{
				return total;
			}
			set{
				if (total >= 0) {
					total = value;
				}
			}
		}
		//Vaciar Maquina y retornar el total
		public int VaciarMaquina (){
				int TempTotal = total;
				Total = 0;
				ContadorTicket = 0;
				return TempTotal;
		}

		public int reembolsoBalance(){
				int montoRetorno = Balance;
				Balance = 0;
				return montoRetorno;
		}
		//Imprimir ticket
		public void ImprimirTicket(){
			if (Balance>=Precio) {
				ContadorTicket++;
				Console.WriteLine ("--------------------------------");
				Console.WriteLine ("TICKET  visite:www.maquinaticket.com");
				Console.WriteLine ("--------------------------------");
				Console.WriteLine ("TICKET #{0}",ContadorTicket);
				Console.WriteLine ("PRECIO --> {0} centavos",Precio);
				Console.WriteLine ("--------------------------------");
				Total += Precio;
				Balance -= Precio;

			} else {
				Console.WriteLine ("Usted necesita {0} centavos mas",(Precio-Balance));
			}
		}
   }
}
