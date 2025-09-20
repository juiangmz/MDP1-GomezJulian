/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
//Ejercicio 13
namespace clase1
{
	public class Alumno:Persona
	{	
		private int legajo;
		private double promedio;
		
		public Alumno(string n, int d, int l, double p):base(n,d)
		{
			this.legajo = l;
			this.promedio = p;
		}
		
		public int getLegajo(){
			return legajo;
		}
		public double getPromedio(){
			return promedio;
		}
		//Ejercicio 15
		public override bool sosIgual(Comparable c){
			return this.promedio == ((Alumno)c).getPromedio();
		}
		public override bool sosMenor(Comparable c){
			return this.promedio < ((Alumno)c).getPromedio();
		}
		public override bool sosMayor(Comparable c){
			return this.promedio > ((Alumno)c).getPromedio();
		}
	}
}
