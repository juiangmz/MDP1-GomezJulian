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
	//EJERCICIO 5
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Alumno(generador.stringAleatorio(8),generador.numeroAleatorio(99999999),generador.numeroAleatorio(9999),generador.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(lector.stringPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado());
		}
	}
}
