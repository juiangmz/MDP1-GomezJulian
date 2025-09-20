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

namespace clase3
{
	//Ejercicio 5
	public class IteradorDePila : Iterador
	{
		private int comparableActual;
		private List<Comparable> elementos;
		
		public IteradorDePila(List<Comparable> e)
		{
			this.elementos = e;
			primero();
		}
		public void primero(){
			this.comparableActual = 0;
		}
		public void siguiente(){
			this.comparableActual += 1;
		}
		public bool fin(){
			return this.comparableActual >= this.elementos.Count;
		}
		public Comparable actual(){
			return this.elementos[comparableActual];
		}
	}
}
