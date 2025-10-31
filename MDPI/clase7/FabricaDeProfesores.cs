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
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Profesor(manejador.stringAleatorio(8), manejador.numeroAleatorio(99999999), manejador.numeroAleatorio(40));
		}
		
		public override Comparable crearPorTeclado(){
			return new Profesor(manejador.stringPorTeclado(),manejador.numeroPorTeclado(),manejador.numeroPorTeclado());
		}
		//EJERCICIO 3
		public override Comparable crearPorArchivo()
		{
			return new Profesor(manejador.stringDesdeArchivo(8),(int)manejador.numeroDesdeArchivo(1),(int)manejador.numeroDesdeArchivo(1));
		}
	}
}
