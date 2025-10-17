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
	public class EstrategiaPorDni : EstrategiaDeComparacion
	{
		public bool sosMenor(Comparable p1, Comparable p2){
			return ((Persona)p1).getDni() < ((Persona)p2).getDni();
		}
		public bool sosMayor(Comparable p1, Comparable p2){
			return ((Persona)p1).getDni() > ((Persona)p2).getDni();
		}
		public bool sosIgual(Comparable p1, Comparable p2){
			return ((Persona)p1).getDni() == ((Persona)p2).getDni();
		}
	}
}
