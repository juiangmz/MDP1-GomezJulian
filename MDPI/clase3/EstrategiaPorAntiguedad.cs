/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 11/9/2025
 * Time: 17:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase3
{
	//Ejercicio 1
	public class EstrategiaPorAntiguedad : EstrategiaDeComparacion
	{
		public bool sosMenor(Persona p1, Persona p2){
			return ((Profesor)p1).getAntiguedad() < ((Profesor)p2).getAntiguedad();
		}
		public bool sosMayor(Persona p1, Persona p2){
			return ((Profesor)p1).getAntiguedad() > ((Profesor)p2).getAntiguedad();
		}
		public bool sosIgual(Persona p1, Persona p2){
			return ((Profesor)p1).getAntiguedad() == ((Profesor)p2).getAntiguedad();
		}
	}
}
