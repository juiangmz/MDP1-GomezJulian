/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{
	//Cambio de Alumno a Persona
	//Cambio de Persona a Comparable
	public interface EstrategiaDeComparacion
	{
		bool sosMenor(Comparable p1, Comparable p2);
		bool sosMayor(Comparable p1, Comparable p2);
		bool sosIgual(Comparable p1, Comparable p2);
	}
}
