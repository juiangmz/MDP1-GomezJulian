/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 20/9/2025
 * Time: 00:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{
	//EJERCICIO 2
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(manejador.stringAleatorio(8),manejador.numeroAleatorio(99999999),manejador.numeroAleatorio(9999),manejador.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(manejador.stringPorTeclado(),manejador.numeroPorTeclado(),manejador.numeroPorTeclado(),manejador.numeroPorTeclado());
		}
		//EJERCICIO 3
		public override Comparable crearPorArchivo()
		{
			return new AlumnoMuyEstudioso(manejador.stringDesdeArchivo(8),(int)manejador.numeroDesdeArchivo(1),(int)manejador.numeroDesdeArchivo(1),manejador.numeroDesdeArchivo(1));
		}
	}
}
