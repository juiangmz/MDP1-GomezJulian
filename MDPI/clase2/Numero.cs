/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase2
{
	//Ejercicio 2
	public class Numero : Comparable
	{
		private int valor;
		public Numero(int v)
		{
			this.valor=v;
		}
		public int getValor(){
			return this.valor;
		}
		
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).getValor();
		}
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).getValor();
		}
	}
}
