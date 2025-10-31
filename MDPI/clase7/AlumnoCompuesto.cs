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

namespace clase7
{

	public class AlumnoCompuesto : IAlumno
	{
		List<IAlumno> hijos;
		public AlumnoCompuesto()
		{
			this.hijos = new List<IAlumno>();
		}
		
		public void agregarHijo(IAlumno hijo){
			this.hijos.Add(hijo);
		}
		public void quitarHijo(IAlumno hijo){
			this.hijos.Remove(hijo);
		}
		public List<IAlumno> getHijos(){
			return this.hijos;
		}
		
		public string getNombre(){
			string nombres = "";
			foreach (IAlumno hijo in hijos) {
				nombres += "\n"+hijo.getNombre();
			}
			return nombres;
		}
		
		public int responderPregunta(int pregunta){
			int[] respuestas = new int[3];
			foreach (IAlumno hijo in hijos) {
				int respuesta = hijo.responderPregunta(pregunta);
				switch (respuesta) {
					case 0: respuestas[0]++;break;
					case 1: respuestas[1]++;break;
					case 2: respuestas[2]++;break;
				}
			}
			int maximo=0;
			int indexMax = 0;
			for(int i=0;i<respuestas.Length;i++){
				if(respuestas[i] > maximo){
					maximo = respuestas[i];
					indexMax = i;
				}
			}
			return indexMax;
		}
		public void setCalificacion(int c){
			foreach (IAlumno hijo in hijos) {
				hijo.setCalificacion(c);
			}
		}
		public string mostrarCalificacion(){
			string calificaciones = "";
			foreach (IAlumno hijo in hijos) {
				calificaciones += "\n"+hijo.getCalificacion();
			}
			return calificaciones;
		}
		public bool sosIgual(Comparable a){
			foreach (IAlumno hijo in hijos) {
				if(hijo.sosIgual((IAlumno)a)){
					return true;
				}
			}
			return false;
		}
		public bool sosMenor(Comparable a){
			foreach (IAlumno hijo in hijos) {
				if(hijo.sosMenor((IAlumno)a)){
					return true;
				}
			}
			return false;
		}
		public bool sosMayor(Comparable a){
			foreach (IAlumno hijo in hijos) {
				if(hijo.sosMayor((IAlumno)a)){
					return true;
				}
			}
			return false;
		}
		
		public void setNombre(string nombre){
			foreach (IAlumno hijo in hijos) {
				hijo.setNombre(nombre);
			}
		}
		public int getDni(){
			return 0;
		}
		public int getLegajo(){
			return 0;
		}
		public double getPromedio(){
			return 0;
		}
		public int getCalificacion(){
			return 0;
		}
		public void setEstrategia(EstrategiaDeComparacion e){
			foreach (IAlumno hijo in hijos) {
				hijo.setEstrategia(e);
			}
		}
		//public string ToString();
		public void prestarAtencion(){
			foreach (IAlumno hijo in hijos) {
				hijo.prestarAtencion();
			}
		}
		public void distraerse(){
			foreach (IAlumno hijo in hijos) {
				hijo.distraerse();
			}
		}
		public void actualizar(Observado o){
			foreach (IAlumno hijo in hijos) {
				hijo.actualizar(o);
			}
		}
	}
}
