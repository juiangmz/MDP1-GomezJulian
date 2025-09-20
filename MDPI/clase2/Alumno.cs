/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
//Ejercicio 2
namespace clase2
{
	public class Alumno:Persona
	{	
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		
		public Alumno(string n, int d, int l, double p):base(n,d)
		{
			this.legajo = l;
			this.promedio = p;
			this.estrategia = new EstrategiaPorLegajo();
		}
		
		public int getLegajo(){
			return legajo;
		}
		public double getPromedio(){
			return promedio;
		}
		//Ejercicio 2
		public void setEstrategia(EstrategiaDeComparacion e){
			this.estrategia = e;
		}
		
		public override bool sosIgual(Comparable c){
			return estrategia.sosIgual(this,(Alumno)c);
		}
		public override bool sosMenor(Comparable c){
			return estrategia.sosMenor(this,(Alumno)c);
		}
		public override bool sosMayor(Comparable c){
			return estrategia.sosMayor(this,(Alumno)c);
		}
		//Ejercicio 6
		public override string ToString()
		{
			return nombre+", "+dni+", "+legajo+", "+promedio;
		}
	}
}
