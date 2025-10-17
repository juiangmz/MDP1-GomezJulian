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
	//Cambio de Alumno a Persona
	public class EstrategiaPorNombre : EstrategiaDeComparacion
	{
		public bool sosMenor(Comparable p1, Comparable p2){
			return (((Persona)p1).getNombre()).Length == (((Persona)p2).getNombre()).Length;
		}
		public bool sosMayor(Comparable p1, Comparable p2){
			return (((Persona)p1).getNombre()).Length == (((Persona)p2).getNombre()).Length;
		}
		public bool sosIgual(Comparable p1, Comparable p2){
			return (((Persona)p1).getNombre()).Length == (((Persona)p2).getNombre()).Length;
		}
	}
}
