/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase5
{
	//Ejercicio 8
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila;
		private Cola cola;
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos(){
			return this.pila.cuantos()+this.cola.cuantos();
		}
		
		public Comparable minimo(){
			if(pila.minimo().sosMenor(cola.minimo())){
				return pila.minimo();
			}else{
				return cola.minimo();
			}
		}
		
		public Comparable maximo(){
			if(pila.maximo().sosMayor(cola.maximo())){
				return pila.maximo();
			}else{
				return cola.maximo();
			}
		}
		
		public void agregar(Comparable c){
			//
		}
		
		public bool contiene(Comparable c){
			return pila.contiene(c) || cola.contiene(c);
		}
	}
}
