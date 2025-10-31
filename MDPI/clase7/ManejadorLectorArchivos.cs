/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 28/10/2025
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{
	//EJERCICIO 3
	public class ManejadorLectorArchivos : Manejador
	{
		//private LectorDeArchivos lector = new LectorDeArchivos();
		private LectorDeArchivos lector = LectorDeArchivos.getInstance();
		public ManejadorLectorArchivos(Manejador sucesor):base(sucesor)
		{
		}
		public override double numeroDesdeArchivo(double max)
		{
			return lector.numeroDesdeArchivo(max);
		}
		public override string stringDesdeArchivo(int cant)
		{
			return lector.stringDesdeArchivo(cant);
		}
		//
		public override int numeroPorTeclado()
		{
			if(sucesor != null){
				return sucesor.numeroPorTeclado();
			}
			throw new NotImplementedException();
		}
		public override string stringPorTeclado()
		{
			if(sucesor != null){
				return sucesor.stringPorTeclado();
			}
			throw new NotImplementedException();
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
	}
}
