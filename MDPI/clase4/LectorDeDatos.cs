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
	//EJERCICIO 3
	public class LectorDeDatos
	{
		public int numeroPorTeclado(){
			Console.WriteLine("Ingrese un numero: ");
			return int.Parse(Console.ReadLine());
		}
		public string stringPorTeclado(){
			Console.WriteLine("Ingrese un texto");
			return Console.ReadLine();
		}
	}
}
