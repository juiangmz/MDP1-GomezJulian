/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 8/10/2025
 * Time: 00:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{

	public class FabricaDeAlumnosCompuestos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoCompuesto();
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoCompuesto();
		}
		public override Comparable crearPorArchivo(){
			return new AlumnoCompuesto();
		}
	}
}
