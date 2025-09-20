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
	//EJERCICIO 8
	public class Profesor : Persona, Observado
	{
		private List<Observador> observadores = new List<Observador>();
		private int antiguedad;
		private EstrategiaDeComparacion estrategia;
		bool hablando;
		public Profesor(string n, int d, int a) : base(n,d)
		{
			this.antiguedad = a;
			this.estrategia = new EstrategiaPorAntiguedad();
		}
		
		public void hablarALaClase(){
			hablando = true;
			Console.WriteLine("Hablando de algun tema");
			this.notificar();
		}
		
		public void escribirEnElPizarron(){
			hablando = false;
			Console.WriteLine("Escribiendo en el pizarron");
			this.notificar();
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
		}
		
		public override string ToString()
		{
			return nombre+", "+dni+", "+antiguedad;
		}
		//Ejercicio 12
		public bool estaHablando(){
			return hablando;
		}
		
		public void agregarObservador(Observador o){
			observadores.Add(o);
		}
		public void quitarObservador(Observador o){
			observadores.Remove(o);
		}
		public void notificar(){
			foreach (Observador o in observadores) {
				o.actualizar(this);
			}
		}
		
	}
}
