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

	public class AlumnoProxy :IAlumno
	{
		private IAlumno alumnoReal = null;
		private int opcion;
		private string nombreProxy;
		public AlumnoProxy(string nombre, int opcion)
		{
			this.nombreProxy = nombre;
			this.opcion = opcion;
		}
		public int responderPregunta(int pregunta){
			if(alumnoReal == null){
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(opcion);
				alumnoReal.setNombre(this.nombreProxy);
				Console.WriteLine("Alumno creado: "+this.nombreProxy);
			}
			return this.alumnoReal.responderPregunta(pregunta);
		}
		public string getNombre(){
			return this.nombreProxy;
		}
		public void setNombre(string nombre){
			this.alumnoReal.setNombre(nombre);
		}
		public int getDni(){
			return this.alumnoReal.getDni();
		}
		public int getLegajo(){
			return this.alumnoReal.getLegajo();
		}
		public double getPromedio(){
			return this.alumnoReal.getPromedio();
		}
		public int getCalificacion(){
			return this.alumnoReal.getCalificacion();
		}
		public void setCalificacion(int c){
			this.alumnoReal.setCalificacion(c);
		}
		public void setEstrategia(EstrategiaDeComparacion e){
			if(alumnoReal == null){
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(opcion);
				alumnoReal.setNombre(this.nombreProxy);
				Console.WriteLine("Alumno creado: "+this.nombreProxy);
			}
			this.alumnoReal.setEstrategia(e);
		}
		/*public string ToString(){
			return this.alumnoReal.ToString();
		}*/
		public void prestarAtencion(){
			this.alumnoReal.prestarAtencion();
		}
		public void distraerse(){
			this.alumnoReal.distraerse();
		}
		public void actualizar(Observado o){
			this.alumnoReal.actualizar(o);
		}
		public string mostrarCalificacion(){
			return this.alumnoReal.mostrarCalificacion();
		}
		public bool sosIgual(Comparable c){
			return this.alumnoReal.sosIgual(c);
		}
		public bool sosMenor(Comparable c){
			return this.alumnoReal.sosMenor(c);
		}
		public bool sosMayor(Comparable c){
			return this.alumnoReal.sosMayor(c);
		}
	}
}
