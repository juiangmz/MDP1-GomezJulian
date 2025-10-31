/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 27/10/2025
 * Time: 21:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{
	//EJERCICIO 1
	public class ManejadorAleatorio : Manejador
	{
		//private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
		GeneradorDeDatosAleatorios generador = GeneradorDeDatosAleatorios.getInstancia();
		public ManejadorAleatorio(Manejador sucesor):base(sucesor)
		{
		}
		
		public override int numeroAleatorio(int max)
		{
			return generador.numeroAleatorio(max);
		}
		public override string stringAleatorio(int cant)
		{
			return generador.stringAleatorio(cant);
		}
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
