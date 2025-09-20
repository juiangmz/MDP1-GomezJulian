/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 20/9/2025
 * Time: 00:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase4
{
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(generador.stringAleatorio(8),generador.numeroAleatorio(99999999),generador.numeroAleatorio(9999),generador.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(lector.stringPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado());
		}
	}
}
