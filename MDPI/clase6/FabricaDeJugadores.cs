/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 11/10/2025
 * Time: 23:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase6
{
	//Ejercicio 5
	public class FabricaDeJugadores : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Jugador(generador.stringAleatorio(8),generador.numeroAleatorio(100000000));
		}
		public override Comparable crearPorTeclado()
		{
			return new Jugador(lector.stringPorTeclado(),lector.numeroPorTeclado());
		}
	}
}
