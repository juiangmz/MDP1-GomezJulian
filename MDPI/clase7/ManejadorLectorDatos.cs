/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 27/10/2025
 * Time: 21:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{
	//EJERCICIO 1
	public class ManejadorLectorDatos : Manejador
	{
		private LectorDeDatos lector = new LectorDeDatos();
		public ManejadorLectorDatos(Manejador sucesor):base(sucesor)	
		{
		}
		public override int numeroPorTeclado()
		{
			return lector.numeroPorTeclado();
		}
		public override string stringPorTeclado()
		{
			return lector.stringPorTeclado();
		}
		public override int numeroAleatorio(int max)
		{
			if(sucesor != null){
				return sucesor.numeroAleatorio(max);
			}
			throw new NotImplementedException();
		}
		public override string stringAleatorio(int cant)
		{
			if(sucesor != null){
				return sucesor.stringAleatorio(cant);
			}
			throw new NotImplementedException();
		}
		public override double numeroDesdeArchivo(double max)
		{
			if(sucesor != null){
				return sucesor.numeroDesdeArchivo(max);
			}
			throw new NotImplementedException();
		}
		public override string stringDesdeArchivo(int cant)
		{
			if(sucesor != null){
				return sucesor.stringDesdeArchivo(cant);
			}
			throw new NotImplementedException();
		}
	}
}
