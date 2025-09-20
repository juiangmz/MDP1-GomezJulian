/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase4
{
	//EJERCICIO 2
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string n,int d,int l, double p):base(n,d,l,p)
		{
		}
		
		public override int responderPregunta(int pregunta)
		{
			return pregunta%3;
		}
		
	}
}
