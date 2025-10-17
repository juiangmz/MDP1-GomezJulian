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

	public class EstrategiaPorCalificacion : EstrategiaDeComparacion
	{
		//EJERCICIO 5
		public bool sosMenor(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getCalificacion() < ((IAlumno)a2).getCalificacion();
		}
		public bool sosMayor(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getCalificacion() > ((IAlumno)a2).getCalificacion();
		}
		public bool sosIgual(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getCalificacion() == ((IAlumno)a2).getCalificacion();
		}
	}
}