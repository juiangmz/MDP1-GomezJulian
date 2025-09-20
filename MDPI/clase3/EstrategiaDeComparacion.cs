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
	public interface EstrategiaDeComparacion
	{
		bool sosMenor(Persona p1, Persona p2);
		bool sosMayor(Persona p1, Persona p2);
		bool sosIgual(Persona p1, Persona p2);
	}
}
