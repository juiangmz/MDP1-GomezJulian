/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase5
{
	//Ejercicio 9
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Profesor(generador.stringAleatorio(8), generador.numeroAleatorio(99999999), generador.numeroAleatorio(40));
		}
		
		public override Comparable crearPorTeclado(){
			return new Profesor(lector.stringPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado());
		}
	}
}
