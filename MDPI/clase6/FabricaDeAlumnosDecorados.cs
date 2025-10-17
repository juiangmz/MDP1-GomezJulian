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
	//EJERCICIO 7
	public class FabricaDeAlumnosDecorados : FabricaDeAlumnos
	{
		public override Comparable crearAleatorio()
		{
			IAlumno student = (IAlumno)FabricaDeComparables.crearAleatorio(2);
			student = new DecoradoConLegajo(student);
			student = new DecoradoConNota(student);
			student = new DecoradoConPromocion(student);
			student = new DecoradoConAsteriscos(student);
			return student;
		}
		
		public override Comparable crearPorTeclado()
		{
			IAlumno student = (IAlumno)FabricaDeComparables.crearPorTeclado(2);
			student = new DecoradoConLegajo(student);
			student = new DecoradoConNota(student);
			student = new DecoradoConPromocion(student);
			student = new DecoradoConAsteriscos(student);
			return student;
		}
	}
}
