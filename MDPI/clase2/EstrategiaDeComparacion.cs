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
	public interface EstrategiaDeComparacion
	{
		bool sosMenor(Alumno a1, Alumno a2);
		bool sosMayor(Alumno a1, Alumno a2);
		bool sosIgual(Alumno a1, Alumno a2);
	}
}
