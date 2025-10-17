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
	/// <summary>
	/// Description of Carta.
	/// </summary>
	public class Carta : Comparable
	{
		private int numero;
		private string palo;
		private int valor;
		
		public Carta(int n, string p, int v){
			this.numero = n;
			this.palo = p;
			this.valor = v;
		}
		public int getNumero(){
			return this.numero;
		}
		public string getPalo(){
			return this.palo;
		}
		public int getValor(){
			return this.valor;
		}
		public void setValor(int nuevoValor){
			this.valor = nuevoValor;
		}
		public bool sosIgual(Comparable c){
			return this.getValor() == ((Carta)c).getValor();
		}
		public bool sosMayor(Comparable c){
			return this.getValor() > ((Carta)c).getValor();
		}
		public bool sosMenor(Comparable c){
			return this.getValor() < ((Carta)c).getValor();
		}
		public override string ToString()
		{
			return this.numero+" de "+this.palo;
		}

	}
}
