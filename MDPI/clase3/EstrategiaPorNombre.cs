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
	//Cambio de Alumno a Persona
	public class EstrategiaPorNombre : EstrategiaDeComparacion
	{
		public bool sosMenor(Persona p1, Persona p2){
			return p1.getNombre().Length == p2.getNombre().Length;
		}
		public bool sosMayor(Persona p1, Persona p2){
			return p1.getNombre().Length == p2.getNombre().Length;
		}
		public bool sosIgual(Persona p1, Persona p2){
			return p1.getNombre().Length == p2.getNombre().Length;
		}
	}
}
