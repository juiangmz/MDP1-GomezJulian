/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace clase6
{
	//EJERCICIO 4
	public class JuegoTruco : JuegoDeCartas
	{
		private static Random r = new Random();
		private Jugador jugador1;
		private Jugador jugador2;
		private string[] palos = new string[]{"Espadas","Bastos","Oro","Copas"};
		private List<Carta> mazo = new List<Carta>();
		
		public JuegoTruco(Jugador j1, Jugador j2){
			this.jugador1 = j1;
			this.jugador2 = j2;
			foreach (var palo in palos) {
				for(int i=1; i<=12;i++){
					if(i!=8 && i!=9){
						int valor = i;
						Carta carta = new Carta(i,palo,valor);
						switch (carta.getNumero()){
							case 1:
								switch (carta.getPalo()) {
									case "Espadas":carta.setValor(10000);break;
									case "Bastos":carta.setValor(9000);break;
									default:carta.setValor(1000);break;
								}
							break;
							case 2:carta.setValor(2000);break;
							case 3:carta.setValor(3000);break;
							case 7:
								switch (carta.getPalo()) {
									case "Espadas":carta.setValor(7500);break;
									case "Oro":carta.setValor(7000);break;
								}
							break;
						}
						mazo.Add(carta);
					}
				}
			}
		}

		protected override void mezclar()
		{
			Console.WriteLine("\nMezclando cartas...");
			for(int i = mazo.Count-1;i>0;i--){
				int j = r.Next(i+1);
				Carta temporal = mazo[i];
				mazo[i]=mazo[j];
				mazo[j]=temporal;
			}
		}
		protected override void repartir(){
			Console.WriteLine("Repartiendo cartas...");
			for(int i=0; i<6; i+=2){
				jugador1.recibirCarta(mazo[i]);
				jugador2.recibirCarta(mazo[i+1]);
			}
			jugador1.verCartas();
			jugador2.verCartas();
			Console.WriteLine("\n");
		}
		
		protected override void tomarCarta(){
			Console.WriteLine("Buscando la carta mas alta...");
			jugador1.elegirCarta((Carta)jugador1.cartaValorMaximo());
			jugador2.elegirCarta((Carta)jugador2.cartaValorMaximo());
			Console.WriteLine("DEBUG:"+this.jugador1.getCartaEnMano().ToString());
		}

		protected override void descartarCarta(){
			Console.WriteLine(jugador1.getNombre()+": Truco!\n"+jugador2.getNombre()+":Quiero!");
			jugador1.getCartas().GetElementos().Remove((Carta)jugador1.cartaValorMaximo());
			jugador2.getCartas().GetElementos().Remove((Carta)jugador2.cartaValorMaximo());
			jugador1.jugarCarta();
			jugador2.jugarCarta();
		}
		protected override bool hayGanador()
		{
			if(jugador1.getCartaEnMano()!=null && jugador2.getCartaEnMano()!=null){
				if(jugador1.getCartaEnMano().sosMayor(jugador2.getCartaEnMano())){
					jugador1.sumarPuntos(2);
					jugador1.eliminarCartas();
					jugador2.eliminarCartas();
					Console.WriteLine("Ganador: "+jugador1.getNombre());
					Console.WriteLine("\nPuntos:");
					jugador1.verPuntos();
					jugador2.verPuntos();
					return true;
				}
				else if(jugador2.getCartaEnMano().sosMayor(jugador1.getCartaEnMano())){
					jugador1.eliminarCartas();
					jugador2.eliminarCartas();
					jugador2.sumarPuntos(2);
					Console.WriteLine("Ganador: "+jugador2.getNombre());
					Console.WriteLine("\nPuntos:");
					jugador1.verPuntos();
					jugador2.verPuntos();
					return true;
				}
			}
			return false;
		}
		
		protected override bool hayGanadorPartida()
		{
			if(jugador1.getPuntos() >= 15)
			{
				Console.WriteLine("Ganador: "+jugador1.getNombre());
				return true;
			}
			else if(jugador2.getPuntos()>=15)
			{
				Console.WriteLine("Ganador: "+jugador1.getNombre());
				return true;
			}
			return false;
		}
	}
}
