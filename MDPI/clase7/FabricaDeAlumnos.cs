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
	//EJERCICIO 2
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Alumno(manejador.stringAleatorio(8),manejador.numeroAleatorio(99999999),manejador.numeroAleatorio(9999),manejador.numeroAleatorio(10));	
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(manejador.stringPorTeclado(),manejador.numeroPorTeclado(),manejador.numeroPorTeclado(),manejador.numeroPorTeclado());
		}
		//EJERCICIO 3
		public override Comparable crearPorArchivo(){
			//rande entre 0 y 1
			return new Alumno(manejador.stringDesdeArchivo(6),(int)manejador.numeroDesdeArchivo(1),(int)(manejador.numeroDesdeArchivo(1)),manejador.numeroDesdeArchivo(1));
		}
	}
}
