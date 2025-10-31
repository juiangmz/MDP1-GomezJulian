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
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Numero(manejador.numeroAleatorio(40));
		}
		public override Comparable crearPorTeclado(){
			return new Numero(manejador.numeroPorTeclado());
		}
		//EJERCICIO 3
		public override Comparable crearPorArchivo()
		{
			return new Numero((int)manejador.numeroDesdeArchivo(1));
		}
	}
}
