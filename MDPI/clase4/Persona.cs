/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase4
{
	//Ejercicio 11
	public class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string n, int d)
		{
			this.nombre = n;
			this.dni = d;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		public int getDni(){
			return this.dni;
		}
		
		public virtual bool sosMenor(Comparable p){
			return this.dni < ((Persona)p).getDni();
		}
		public virtual bool sosMayor(Comparable p){
			return this.dni > ((Persona)p).getDni();
		}
		public virtual bool sosIgual(Comparable p){
			return this.dni == ((Persona)p).getDni();
		}
	}
}
