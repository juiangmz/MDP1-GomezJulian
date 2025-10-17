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
	//Ejercicio 1
	public class EstrategiaPorLegajo : EstrategiaDeComparacion
	{
		public bool sosMenor(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getLegajo() < ((IAlumno)a2).getLegajo();
		}
		public bool sosMayor(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getLegajo() > ((IAlumno)a2).getLegajo();
		}
		public bool sosIgual(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getLegajo() == ((IAlumno)a2).getLegajo();
		}
	}
}
