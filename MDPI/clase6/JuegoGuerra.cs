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
	public class JuegoGuerra : JuegoDeCartas
	{
		private static Random r = new Random();
		private Jugador jugador1;
		private Jugador jugador2;
		private bool juegoEmpezado;
		private Pila cartasGanadasJ1;
		private Pila cartasGanadasJ2;
		private Pila pozo;
		private string[] palos = new string[]{"Espadas","Bastos","Oro","Copas"};
		private List<Carta> mazo = new List<Carta>();
		
		public JuegoGuerra(Jugador j1, Jugador j2){
			this.jugador1 = j1;
			this.jugador2 = j2;
			this.cartasGanadasJ1 = new Pila();
			this.cartasGanadasJ2 = new Pila();
			this.pozo = new Pila();
			this.juegoEmpezado = false;
			foreach (var palo in palos) {
				for(int i=1; i<=12;i++){
					int valor = i;
					Carta carta = new Carta(i,palo,valor);
					if(carta.getValor() == 1){
						carta.setValor(20);
					}
					mazo.Add(carta);
				}
			}
		}

		protected override void mezclar()
		{
			if(!this.juegoEmpezado){
				Console.WriteLine("\nMezclando cartas...");
				for(int i = mazo.Count-1;i>0;i--){
					int j = r.Next(i+1);
					Carta temporal = mazo[i];
					mazo[i]=mazo[j];
					mazo[j]=temporal;
				}	
			}
		}
		
		protected override void repartir(){
			if(!this.juegoEmpezado){
				Console.WriteLine("Repartiendo cartas...");
				for(int i=0; i<mazo.Count; i+=2){
					jugador1.recibirCarta(mazo[i]);
					jugador2.recibirCarta(mazo[i+1]);
				}
				this.juegoEmpezado = true;
			}
			jugador1.verCartas();
			Console.WriteLine("\n");
			jugador2.verCartas();
			Console.WriteLine("\n");	
		}
		protected override void tomarCarta(){
			Console.WriteLine("Eligiendo carta superior del mazo...");
			Carta cartaJ1 = (Carta)jugador1.desapilarCarta();
			Carta cartaJ2 = (Carta)jugador2.desapilarCarta();
			jugador1.elegirCarta((Carta)cartaJ1);
			jugador2.elegirCarta((Carta)cartaJ2);
		}
		protected override void descartarCarta()
		{
			jugador1.jugarCarta();
			jugador2.jugarCarta();
			pozo.apilar((Carta)jugador1.getCartaEnMano());
			pozo.apilar((Carta)jugador2.getCartaEnMano());
		}
		
		protected override bool hayGanador()
		{
			Iterador iterador = pozo.crearIterador();
			if (jugador1.getCartaEnMano()!=null) {
				if(jugador1.getCartaEnMano().sosMayor(jugador2.getCartaEnMano())){
					while (!iterador.fin()) {
						cartasGanadasJ1.apilar((Carta)iterador.actual());
						iterador.siguiente();
					}
					pozo = new Pila();
					Console.WriteLine("Ganador de mano: "+jugador1.getNombre());
					jugador1.eliminarCartaEnMano();
					jugador2.eliminarCartaEnMano();
					return true;
				}
				else if(jugador2.getCartaEnMano().sosMayor(jugador1.getCartaEnMano())){
					while (!iterador.fin()) {
						cartasGanadasJ2.apilar((Carta)iterador.actual());
						iterador.siguiente();
					}
					pozo = new Pila();
					Console.WriteLine("Ganador de mano: "+jugador2.getNombre());
					jugador1.eliminarCartaEnMano();
					jugador2.eliminarCartaEnMano();
					return true;
				}
				else{
					Console.WriteLine("Empate");
				}	
			}
			return false;
		}
		
		protected override bool hayGanadorPartida()
		{
			if(jugador1.getCartas().cuantos() == 0 && jugador2.getCartas().cuantos() == 0 && juegoEmpezado){
				Console.WriteLine(this.jugador1.getNombre()+" = "+cartasGanadasJ1.cuantos()+" cartas ganadas.");
				Console.WriteLine(this.jugador2.getNombre()+" = "+cartasGanadasJ2.cuantos()+" cartas ganadas.");
				if(this.cartasGanadasJ1.cuantos()>this.cartasGanadasJ2.cuantos()){
					Console.WriteLine("Ganador: "+this.jugador1.getNombre());
				}
				else if(this.cartasGanadasJ1.cuantos()<this.cartasGanadasJ2.cuantos()){
					Console.WriteLine("Ganador: "+this.jugador2.getNombre());
				}
				return true;
			}
			
			return false;
			
		}
	}
}
