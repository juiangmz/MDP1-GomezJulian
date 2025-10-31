/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{

	public abstract class AlumnoDecorator : IAlumno
	{
		protected IAlumno adicional;
		public AlumnoDecorator(IAlumno al){
			this.adicional = al;
		}
		public virtual string mostrarCalificacion(){
			return this.adicional.mostrarCalificacion();
		}
		
		public string getNombre(){
			return this.adicional.getNombre();
		}
		public int getDni(){
			return this.adicional.getDni();
		}
		public int getLegajo(){
			return this.adicional.getLegajo();
		}
		public double getPromedio(){
			return this.adicional.getPromedio();
		}
		public int getCalificacion(){
			return this.adicional.getCalificacion();
		}
		public void setCalificacion(int c){
			this.adicional.setCalificacion(c);
		}
		
		public void setEstrategia(EstrategiaDeComparacion e){
			this.adicional.setEstrategia(e);
		}
		
		public void setNombre(string nombre){
			this.adicional.setNombre(nombre);
		}
		
		public void prestarAtencion(){
			this.adicional.prestarAtencion();
		}
		public void distraerse(){
			this.adicional.distraerse();
		}
		public void actualizar(Observado o){
			this.adicional.actualizar(o);
		}
		public int responderPregunta(int pregunta){
			return this.adicional.responderPregunta(pregunta);
		}
		
		public bool sosIgual(Comparable c){
			return this.adicional.sosIgual(c);
		}
		public bool sosMenor(Comparable c){
			return this.adicional.sosMenor(c);
		}
		public bool sosMayor(Comparable c){
			return this.adicional.sosMayor(c);
		}
	}
}
