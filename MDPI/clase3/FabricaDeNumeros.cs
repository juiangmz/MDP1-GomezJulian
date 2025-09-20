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
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Numero(generador.numeroAleatorio(40));
		}
		public override Comparable crearPorTeclado(){
			return new Numero(lector.numeroPorTeclado());
		}
	}
}
