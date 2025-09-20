/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase3
{
	//Ejercicio 1
	public class EstrategiaPorLegajo : EstrategiaDeComparacion
	{
		public bool sosMenor(Persona a1, Persona a2){
			return ((Alumno)a1).getLegajo() < ((Alumno)a2).getLegajo();
		}
		public bool sosMayor(Persona a1, Persona a2){
			return ((Alumno)a1).getLegajo() > ((Alumno)a2).getLegajo();
		}
		public bool sosIgual(Persona a1, Persona a2){
			return ((Alumno)a1).getLegajo() == ((Alumno)a2).getLegajo();
		}
	}
}
