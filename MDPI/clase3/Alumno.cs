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
//Ejercicio 2
namespace clase3
{
	public class Alumno:Persona,Observador
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

		public override string ToString()
		{
			return nombre+", "+dni+", "+legajo+", "+promedio;
		}
		
		//Ejercicio 11
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		static Random random = new Random();
		public void distraerse(){
			List<string> distracciones = new List<string>(){"Mirando el celular","Dibujando en el margen de la carpeta","Tirando aviones de papel"};
			Console.WriteLine(distracciones[random.Next(0,distracciones.Count)]);
		}
		//Ejercicio 12
		public void actualizar(Observado o){
			if(((Profesor)o).estaHablando()){
				this.prestarAtencion();
			}else{
				this.distraerse();
			}
		}
	}
}
