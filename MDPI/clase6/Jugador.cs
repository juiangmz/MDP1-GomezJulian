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
	public class Jugador : Persona
	{
		private Pila cartas;
		private Carta cartaEnMano = null;
		private int puntos;
		public Jugador(string n, int d):base(n,d){
			this.cartas = new Pila();
			this.puntos = 0;
		}
		public int getPuntos(){
			return this.puntos;
		}
		public void sumarPuntos(int p){
			this.puntos+= p;
		}
		public void resetearPuntos(){
			this.puntos = 0;
		}
		public void verPuntos(){
			Console.WriteLine("*"+this.nombre+" : "+this.puntos);
		}
		public Comparable cartaValorMaximo(){
			return cartas.maximo();
		}
		public void recibirCarta(Carta c){
			cartas.apilar(c);
		}
		public void elegirCarta(Carta c){
			this.cartaEnMano = c;
		}
		public Pila getCartas(){
			return this.cartas;
		}
		public Carta desapilarCarta(){
			return (Carta)this.cartas.desapilar();
		}
		public void eliminarCartas(){
			this.cartas.GetElementos().Clear();
			this.cartaEnMano = null;
		}
		
		public void eliminarCartaEnMano(){
			this.cartaEnMano = null;
		}
		public Carta getCartaEnMano(){
			return this.cartaEnMano;
		}
		public void verCartas(){
			string s = this.nombre+": | ";
			Iterador iterador = this.cartas.crearIterador();
			while (!iterador.fin()) {
				s += iterador.actual().ToString()+" | ";
				iterador.siguiente();
			}
			Console.WriteLine(s);
		}
		public void jugarCarta(){
			if(this.getCartaEnMano()!=null){
				Console.WriteLine(this.nombre+" juega un "+this.getCartaEnMano().ToString());
			}
		}
	}
}
