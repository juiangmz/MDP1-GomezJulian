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

namespace clase6
{
	public class Alumno:Persona,Observador,IAlumno
	{	
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		private int calificacion;
		
		public Alumno(string n, int d, int l, double p):base(n,d)
		{
			this.legajo = l;
			this.promedio = p;
			this.estrategia = new EstrategiaPorLegajo();
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		public double getPromedio(){
			return this.promedio;
		}

		public int getCalificacion(){
			return this.calificacion;
		}
		
		public void setCalificacion(int c){
			this.calificacion = c;
		}
		public EstrategiaDeComparacion getEstrategia(){
			return this.estrategia;
		}
		public void setEstrategia(EstrategiaDeComparacion e){
			this.estrategia = e;
		}
		
		public override bool sosIgual(Comparable c){
			return estrategia.sosIgual(this,(IAlumno)c);
		}
		public override bool sosMenor(Comparable c){
			return estrategia.sosMenor(this,(IAlumno)c);
		}
		public override bool sosMayor(Comparable c){
			return estrategia.sosMayor(this,(IAlumno)c);
		}

		public override string ToString()
		{
			return nombre+", "+dni+", "+legajo+", "+promedio;
		}
		
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		static Random random = new Random();
		public void distraerse(){
			List<string> distracciones = new List<string>(){"Mirando el celular","Dibujando en el margen de la carpeta","Tirando aviones de papel"};
			Console.WriteLine(distracciones[random.Next(0,distracciones.Count)]);
		}

		public void actualizar(Observado o){
			if(((Profesor)o).estaHablando()){
				this.prestarAtencion();
			}else{
				this.distraerse();
			}
		}

		public virtual int responderPregunta(int pregunta){
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			return generador.numeroAleatorio(3);
		}
		public string mostrarCalificacion(){
			return this.getNombre()+"\t"+this.getCalificacion();
		}
	}
}
