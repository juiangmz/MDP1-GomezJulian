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
	public class EstrategiaPorDni : EstrategiaDeComparacion
	{
		public bool sosMenor(Persona p1, Persona p2){
			return p1.getDni() < p2.getDni();
		}
		public bool sosMayor(Persona p1, Persona p2){
			return p1.getDni() > p2.getDni();
		}
		public bool sosIgual(Persona p1, Persona p2){
			return p1.getDni() == p2.getDni();
		}
	}
}
