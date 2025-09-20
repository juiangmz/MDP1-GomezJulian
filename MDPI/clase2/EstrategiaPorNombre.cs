/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase2
{
	//Ejercicio 1
	public class EstrategiaPorNombre : EstrategiaDeComparacion
	{
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getNombre().Length == a2.getNombre().Length;
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getNombre().Length == a2.getNombre().Length;
		}
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getNombre().Length == a2.getNombre().Length;
		}
	}
}
