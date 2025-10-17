/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase6
{
	//Ejercicio3
	public abstract class JuegoDeCartas
	{
		//Ejercicio 3
		/*
		public void jugar(){
			mezclar();
			repartir();
			while (!hayGanador()) {
				tomarCarta();
				descartarCarta();
			}
		}
		*/
		
		//Ejercicio 6
		public void jugar(){
			while (!hayGanadorPartida()){
				mezclar();
				repartir();
				while (!hayGanador()) {
					tomarCarta();
					descartarCarta();
				}		
			}
		}
		
		protected abstract void mezclar();
		protected abstract void repartir();
		protected abstract void tomarCarta();
		protected abstract void descartarCarta();
		protected abstract bool hayGanador();
		//Ejercicio 6
		protected abstract bool hayGanadorPartida();
	}
}
